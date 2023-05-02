

using ExampleProject.Core.Entities.Abstract;
using System.Linq.Expressions;

namespace ExampleProject.Core.Data.Abstract;

public interface IEntityRepository<T> where T : class, IEntity,new()
{
    Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includeProperties);
    Task AddAsync(T entity);
    Task Delete(T entity);
    Task UpdateAsync(T entity);
    Task<bool> Any(Expression<Func<T, bool>> predicate);
    Task<int> Count(Expression<Func<T, bool>> predicate);
}
