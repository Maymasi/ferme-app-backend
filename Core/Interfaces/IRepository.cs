using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask AddAsync(TEntity entity);
        ValueTask<TEntity> GetByIdAsync(string id);
        ValueTask<IEnumerable<TEntity>> GetAllAsync();
        ValueTask UpdateAsync(TEntity entity);
        ValueTask DeleteAsync(string id);
        Task<int> SaveChanges();

    }
}
