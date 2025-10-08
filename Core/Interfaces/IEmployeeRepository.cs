using Core.Entities;
namespace Core.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        ValueTask<IEnumerable<Employee>> GetByNameAsync(string name);
    }
}
