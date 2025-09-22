using Core.Entities;

namespace Core.Interfaces
{
    public interface IFarmRepository
    {
        ValueTask AddAsync(Farm farm);
        ValueTask<Farm> GetByIdAsync(int id);
        ValueTask<IEnumerable<Farm>> GetAllAsync();
        ValueTask UpdateAsync(Farm farm);
        ValueTask DeleteAsync(int id);
    }
}
