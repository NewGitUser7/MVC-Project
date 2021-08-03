using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Data.Edmx
{
    public partial class MEEntities
    {
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
