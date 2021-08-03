using log4net;
using ME.Data.Contracts;
using ME.Data.Implementation;
using ME.Data.Model;
using ME.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Services.Implementation
{
    public partial class MEService : IMEService
    {
        #region Constructor
        private IMEUnitOfWork _meunitofwork;
        public MEService(ILog log)
        {
            _meunitofwork = new MEUnitOfWork();
            Log = log;
        }

        private ILog Log { get; set; }
        #endregion

        #region Dispose
        private bool _isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if(_isDisposed == false && disposing == true)
            {
                if(_meunitofwork!=null)
                {
                    _meunitofwork.Dispose();
                    _meunitofwork = null;
                }
            }
            _isDisposed = true;
            
        }
        #endregion

        ~MEService()
        {
            Dispose(false);
        }
    }
}
