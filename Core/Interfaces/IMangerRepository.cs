using Core.Entities;

namespace Core.Interfaces
{
    public interface IMangerRepository
    {
        ValueTask AddAsync(Manager manager);
        ValueTask<Manager> GetByIdAsync(string id);
        ValueTask<IEnumerable<Manager>> GetAllAsync();
        ValueTask UpdateAsync(Manager manager);
        ValueTask DeleteAsync(string id);


    }
}
