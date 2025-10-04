
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class CropRepository : ICropRepository
    {
        private ApplicationDbContext _context;
        public CropRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask AddAsync(Crop crop) =>
            await _context.Crops.AddAsync(crop);

        public async ValueTask DeleteAsync(string id)
        {
            var crop =await _context.Crops.FindAsync(id);
            _context.Crops.Remove(crop);
        }

        public async ValueTask<IEnumerable<Crop>> GetAllAsync() =>
            await _context.Crops.ToListAsync();


        public async ValueTask<Crop> GetByIdAsync(string id) =>
            await _context.Crops.FindAsync(id);


        public async ValueTask<IEnumerable<Crop>> GetByYear(string year)
        {
            var Odata = await _context.Crops.Where(x => x.harvestYear == year).ToListAsync();
            return Odata;
        }

        public async ValueTask UpdateAsync(Crop crop) =>
            _context.Crops.Update(crop);
    
    }
}
