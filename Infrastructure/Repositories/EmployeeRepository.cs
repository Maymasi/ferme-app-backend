using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {

        public EmployeeRepository(ApplicationDbContext context):base(context){}

        public async ValueTask<IEnumerable<Employee>> GetByNameAsync(string name)
        {
            var employees = await _entity.Where(x => x.firstName == name).ToListAsync();
            return employees;
        }

    }
}
