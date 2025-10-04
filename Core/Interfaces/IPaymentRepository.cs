using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPaymentRepository
    {
        ValueTask AddAsync(Payment payment);
        ValueTask<Payment> GetByIdAsync(string id);
        ValueTask<IEnumerable<Payment>> GetByNameAsync(string name);
        ValueTask<IEnumerable<Payment>> GetByDate(DateTime date);
        ValueTask<IEnumerable<Payment>> GetAllAsync();
        ValueTask UpdateAsync(Payment payment);
        ValueTask DeleteAsync(string id);
        int SaveChanges();


    }
}
