using log4net;
using ME.Services.Contracts;
using ME.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Services.Factories
{
    public class ServiceFactory : IServiceFactory
    {
        private ILog Log { get; set; }
        public ServiceFactory(ILog log)
        {
            Log = log;
        }
        public IMEService Create()
        {
            return new MEService(Log);
        }
    }
}
