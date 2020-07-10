using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        void Delete(object id);
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
         
        Task<TEntity> FindAsync(object id);
        TEntity Find(object id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
        bool Any(Expression<Func<TEntity, bool>> filter);
         
        //IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }


}
