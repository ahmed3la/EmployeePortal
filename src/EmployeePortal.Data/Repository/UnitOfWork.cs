using EmployeePortal.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{

    public class UnitOfWork : IUnitOfWork  
    {
        private PortalContext  _dbContext;
        private Repository<Employee> _employees;
        private Repository<EmployeeType> _employeeTypes;

        public UnitOfWork(PortalContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Employee> Employees
        {
            get
            {
                return _employees ??
                    (_employees = new Repository<Employee>(_dbContext));
            }
        }

        public IRepository<EmployeeType> EmployeeTypes
        {
            get
            {
                return _employeeTypes ??
                    (_employeeTypes = new Repository<EmployeeType>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
             return await _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            
        }
    }
}
