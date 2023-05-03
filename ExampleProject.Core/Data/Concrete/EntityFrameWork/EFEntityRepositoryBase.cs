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

    public async Task AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public async Task<bool> Any(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().AnyAsync(predicate);
    }

    public async Task<int> Count(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().CountAsync(predicate);
    }

    public async Task Delete(T entity)
    {
        await Task.Run(() => (_context.Set<T>().Remove(entity)));
    }

    public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _context.Set<T>();
        if (predicate != null)
        {
            query = query.Where(predicate);

        }

        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }

        return await query.ToListAsync();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _context.Set<T>();
        if (predicate != null)
        {
            query = query.Where(predicate);

        }

        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }

        return await query.SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        await Task.Run(() =>
        {
            _context.Set<T>().Update(entity);

        });
    }
}
