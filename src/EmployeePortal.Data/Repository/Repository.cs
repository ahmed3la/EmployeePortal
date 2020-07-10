using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Repository
{
    //https://garywoodfine.com/generic-repository-pattern-net-core/

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal PortalContext context;
        internal DbSet<TEntity> dbSet;

        public Repository(PortalContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        //public virtual IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters)
        //{
        //    return dbSet.FromSql(query, parameters).ToList();

        //}

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public virtual async Task<IEnumerable<TEntity>> GetAsync(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                 return await orderBy(query).ToListAsync();
            }
            else
            {
                 return await query.ToListAsync();
            }
        }
        public virtual TEntity Find(object id)
        {
            return dbSet.Find(id);
        }
        public virtual async Task<TEntity> FindAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }
  
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            return dbSet.FirstOrDefault(filter);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await dbSet.FirstOrDefaultAsync(filter);
        }
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await dbSet.AnyAsync(filter);
        }
        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return dbSet.Any(filter);
        }
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

      
    }
}