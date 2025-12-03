using Core.Entities;
namespace Core.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        ValueTask<Employee?> GetByFullNameAsync(string fName, string lName);
    }
}
