using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    internal interface IPaymentRepository
    {
        ValueTask AddAsync(Payment payment);
        ValueTask<Payment> GetByIdAsync(string id);
        ValueTask<IQueryable<Payment>> GetByNameAsync(string name);
        ValueTask<IQueryable<Payment>> GetByDate(DateTime date);
        ValueTask<IEnumerable<Payment>> GetAllAsync();
        ValueTask UpdateAsync(Payment payment);
        ValueTask DeleteAsync(string id);


    }
}
