using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SchoolManagementSystem.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbSet;
        public Repository()
        {
            _dbSet = _context.Set<T>();
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>>? condition, List<Expression<Func<T, object>>>? includes, bool tracking = true)
        {
            var result = _dbSet.AsQueryable();
            if (condition is not null)
            {
                result = result.Where(condition);
            }
            if (!tracking)
            {
                result = result.AsNoTracking();
            }
            if (includes is not null)
            {
                foreach (var item in includes)
                {
                    result = result.Include(item).AsQueryable();
                }
            }
            return await result.ToListAsync();
        }
        public T? GetOne(Expression<Func<T, bool>>? condition)
        {
            if (condition is not null)
                return _dbSet.FirstOrDefault(condition);
            return _dbSet.FirstOrDefault();
        }
    }
}
