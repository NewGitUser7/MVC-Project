using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Data.Contracts;
using ME.Data.Implementation;
using ME.Data.Edmx;


namespace ME.Data.Implementation
{
    public class MEUnitOfWork : IMEUnitOfWork
    {
        #region Constructor
        private MEEntities _entities;
        public MEUnitOfWork()
        {
            _entities = new MEEntities();
        }
        #endregion
        private IMERepository _merepository;
        public IMERepository MERepository
        {
            get
            {
                return _merepository ?? (_merepository = new MERepository(_entities));
            }
        }

        #region Dispose
        private bool _isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (_isDisposed == false && disposing == true)
            {
                if (_entities != null)
                {
                    _entities.Dispose();
                    _entities = null;
                }
            }
            _isDisposed = true;
        }
        #endregion

        ~MEUnitOfWork()
        {
            Dispose(false);
        }
    }
}
