using System.Linq.Expressions;

namespace SchoolManagementSystem.Repositories
{
    public interface IRepository <T> where T : class
    {
        public Task<List<T>> GetAsync(Expression<Func<T, bool>>? condition, List<Expression<Func<T, object>>>? includes, bool tracking = true);
        public T? GetOne(Expression<Func<T, bool>>? condition);
        void Create(T entity);
        void Edit(T entity);
        void Delete(T entity);
        Task CommitAsync();
    }
}
