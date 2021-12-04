using BlogShared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace BlogShared.Data.Concrete
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        #region Field
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbset;
        #endregion
        #region Ctor
        public EfRepositoryBase(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        #endregion

        public async Task AddAsync(TEntity entity)
        {
             await _dbset.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.AnyAsync(predicate);
        }


        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.CountAsync(predicate);
        }

        public async 
            Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _dbset.Remove(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbset;
            if (predicate is not null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties is not null)
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }

            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbset;
            if(predicate is not null)
            {
                query = query.Where(predicate);
            }
            if(includeProperties is not null)
            {
                foreach(var item in includeProperties)
                {
                    query = query.Include(item);
                }
                
            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(()=> { _dbset.Update(entity); });
        }
    }
}