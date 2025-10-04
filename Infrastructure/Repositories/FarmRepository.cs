
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class FarmRepository : IFarmRepository
    {
        private ApplicationDbContext _context;

        public FarmRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async ValueTask AddAsync(Farm farm) =>
            await _context.Farms.AddAsync(farm);

        public async ValueTask DeleteAsync(int id)
        {
            var farm = await _context.Farms.FindAsync(id);
            _context.Farms.Remove(farm);
        }

        public async ValueTask<IEnumerable<Farm>> GetAllAsync() =>
            await _context.Farms.ToListAsync();

        public async ValueTask<Farm> GetByIdAsync(int id) =>
             await _context.Farms.FindAsync(id);

        public async ValueTask UpdateAsync(Farm farm) =>
            _context.Farms.Update(farm);

        public int SaveChanges() => _context.SaveChanges();
    }
}
