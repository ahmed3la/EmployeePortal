using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            unitOfWork.Context.Set<T>().Remove(entity);
        }

        public async Task<T> FindAsync(int id)
        {
            return await unitOfWork.Context.Set<T>().FindAsync(id);
        }

        public IAsyncEnumerable<T> GetAsync()
        {
            return unitOfWork.Context.Set<T>().AsAsyncEnumerable();
        }

        public IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return unitOfWork.Context.Set<T>().Where(predicate).AsAsyncEnumerable();
        }

        public void Update(T entity)
        {
            unitOfWork.Context.Set<T>().Update(entity);
        }

         
    } 
}
