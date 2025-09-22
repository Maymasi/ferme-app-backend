using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEmployeeRepository
    {
        ValueTask AddAsync(Employee employee);
        ValueTask<Employee> GetByIdAsync(string id);
        ValueTask<IEnumerable<Employee>> GetAllAsync();
        ValueTask<IQueryable<Employee>> GetByNameAsync(string name);

        ValueTask UpdateAsync(Employee employee);
        ValueTask DeleteAsync(string id);
    }
}
