using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context):base(context){}

        public async ValueTask<Employee?> GetByFullNameAsync(string fName, string lName)
        {
            var employee = await _entity.FirstOrDefaultAsync(x => x.firstName == fName && x.lastName == lName);
            return employee;
        }
    }
}
