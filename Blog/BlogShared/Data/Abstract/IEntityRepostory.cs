using BlogShared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogShared.Data
{
  
        public interface IEntityRepository<T> where T : class, IEntity, new()
        {
            // queries
            Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
            Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

            Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
            Task<int> CountAsync(Expression<Func<T, bool>> predicate);

            // crud
            Task AddAsync(T entity);
            Task UpdateAsync(T entity);
            Task DeleteAsync(T entity);
        }
    }

