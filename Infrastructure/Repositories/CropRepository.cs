
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class CropRepository : Repository<Crop> , ICropRepository
    {
        public CropRepository(ApplicationDbContext context) : base(context){ }
        public async ValueTask<IEnumerable<Crop>> GetByYear(string year)
        {
            var crops = await _entity.Where(x => x.harvestYear == year).ToListAsync();
            return crops;
        }

    }
}
