using Core.Entities;
namespace Core.Interfaces
{
    public interface ICropRepository
    {
        ValueTask AddAsync(Crop crop);
        ValueTask<Crop> GetByIdAsync(string id);
        ValueTask<IEnumerable<Crop>> GetByYear(string year);
        ValueTask<IEnumerable<Crop>> GetAllAsync();
        ValueTask UpdateAsync(Crop crop);
        ValueTask DeleteAsync(string id);
        int SaveChanges();
    }
}
