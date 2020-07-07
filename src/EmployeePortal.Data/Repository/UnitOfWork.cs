using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        //public PortalContext Context => throw new NotImplementedException();
        public PortalContext Context { get; }
        public UnitOfWork(PortalContext context )
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
        public async Task DisposeAsync()
        {
            await Context.DisposeAsync();
        }
    }
}
