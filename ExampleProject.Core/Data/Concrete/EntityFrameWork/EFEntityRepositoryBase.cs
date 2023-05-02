using ExampleProject.Core.Data.Abstract;
using ExampleProject.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExampleProject.Core.Data.Concrete.EntityFrameWork;

public class EFEntityRepositoryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
{

    private readonly DbContext _context;

    public EFEntityRepositoryBase(DbContext context)
    {
        _context = context;
    }

    public async  Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Any(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<int> Count(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
