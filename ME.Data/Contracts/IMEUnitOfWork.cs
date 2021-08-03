using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Data.Contracts
{
    public interface IMEUnitOfWork : IDisposable
    {
        IMERepository MERepository { get; }
    }
}
