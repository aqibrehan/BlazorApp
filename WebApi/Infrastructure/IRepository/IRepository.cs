using System.Linq.Expressions;

namespace WebApi.Infrastructure.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, string? includeproperties = null);
        T GetT(Expression<Func<T, bool>> predicate, string? includeproperties = null);
        void Add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
    }
}
