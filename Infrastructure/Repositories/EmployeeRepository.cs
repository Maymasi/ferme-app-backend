using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask AddAsync(Employee employee) => 
            await _context.Employees.AddAsync(employee);

        public async ValueTask DeleteAsync(string id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
                _context.Employees.Remove(employee);
        }

        public async ValueTask<IEnumerable<Employee>> GetAllAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async ValueTask<Employee> GetByIdAsync(string id) =>
            await _context.Employees.FindAsync(id);

        public async ValueTask<IEnumerable<Employee>> GetByNameAsync(string name)
        {
            var oData = await _context.Employees.Where(x => x.firstName == name).ToListAsync();
            return oData;
        }

        public int SaveChanges() => _context.SaveChanges();

        public async ValueTask UpdateAsync(Employee employee) =>
            _context.Employees.Update(employee);


    }
}
