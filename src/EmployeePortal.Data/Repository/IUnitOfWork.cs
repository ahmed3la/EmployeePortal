using EmployeePortal.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> Employees { get; }
        IRepository<EmployeeType> EmployeeTypes { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
