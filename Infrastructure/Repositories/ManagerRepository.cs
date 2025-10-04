using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ManagerRepository : IMangerRepository
    {
        private ApplicationDbContext _context;
        public ManagerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async ValueTask AddAsync(Manager manager) =>
            await _context.Managers.AddAsync(manager);

        public async ValueTask DeleteAsync(string id)
        {
            var manager = await _context.Managers.FindAsync(id) ;
            _context.Managers.Remove(manager);
        }

        public async ValueTask<IEnumerable<Manager>> GetAllAsync() =>
             await _context.Managers.ToListAsync();

        public async ValueTask<Manager> GetByIdAsync(string id)
        {
            var manager = await _context.Managers.FindAsync(id);
            return manager;
        }

        public async ValueTask UpdateAsync(Manager manager) =>
            _context.Managers.Update(manager);

        public int SaveChanges() => _context.SaveChanges();
    }
}
