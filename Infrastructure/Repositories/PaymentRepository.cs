using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class PaymentRepository : Repository<Payment> , IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context):base(context){}

        public async ValueTask<IEnumerable<Payment>> GetByDate(DateTime date)
        {
            var payment = await _entity.Where(x => x.effectivePaymentDate == date).ToListAsync();
            return payment;
        }

        public async ValueTask<IEnumerable<Payment>> GetByNameAsync(string name)
        {
            var payment = await _entity.Where(x => x.employee.firstName == name).ToListAsync();
            return payment;
        }
    }
}
