using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }
        public async ValueTask AddAsync(TEntity entity) =>
            await _entity.AddAsync(entity);

        public async ValueTask<TEntity> GetByIdAsync(string id) =>
            await _entity.FindAsync(id);

        public async ValueTask<IEnumerable<TEntity>> GetAllAsync() =>
            await _entity.ToListAsync();


        public async ValueTask UpdateAsync(TEntity entity) =>
            _entity.Update(entity);

        public async ValueTask DeleteAsync(string id)
        {
            var oData = await _entity.FindAsync(id);
            _entity.Remove(oData);
        }

        public async Task<int> SaveChanges() =>
            await _context.SaveChangesAsync();

    }

}
