using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        PortalContext Context { get; }
        Task CommitAsync();
        void Commit();

    }
}
