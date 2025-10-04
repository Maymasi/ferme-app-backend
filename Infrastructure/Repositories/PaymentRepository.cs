using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Repositories
{
    internal class PaymentRepository : IPaymentRepository
    {
        private ApplicationDbContext _context;
        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask AddAsync(Payment payment) =>
            await _context.Payments.AddAsync(payment);

        public async ValueTask DeleteAsync(string id)
        {
            var payment = await _context.Payments.FindAsync(id);
            _context.Payments.Remove(payment);
        }

        public async ValueTask<IEnumerable<Payment>> GetAllAsync() =>
             await _context.Payments.ToListAsync();

        public async ValueTask<IEnumerable<Payment>> GetByDate(DateTime date)
        {
            var payment = await _context.Payments.Where(x => x.effectivePaymentDate == date).ToListAsync();
            return payment;
        }

        public async ValueTask<Payment> GetByIdAsync(string id)
        {
            var payment = await _context.Payments.FindAsync(id);
            return payment;
        }

        public async ValueTask<IEnumerable<Payment>> GetByNameAsync(string name)
        {
            var payment = await _context.Payments.Where(x => x.employee.firstName == name).ToListAsync();
            return payment;
        }

        public int SaveChanges() => _context.SaveChanges();

        public async ValueTask UpdateAsync(Payment payment) =>
            _context.Payments.Update(payment);
    }
}
