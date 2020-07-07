using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public interface IRepository<T> where T:class
    {
        public IAsyncEnumerable<T> GetAsync();
        public Task<T> FindAsync(int id);
        public IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> predicate);
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}
