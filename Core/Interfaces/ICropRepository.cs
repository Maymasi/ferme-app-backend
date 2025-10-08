using Core.Entities;
namespace Core.Interfaces
{
    public interface ICropRepository : IRepository<Crop>
    {
        ValueTask<IEnumerable<Crop>> GetByYear(string year);

    }
}
