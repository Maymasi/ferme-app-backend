using Core.Entities;

namespace Core.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        ValueTask<IEnumerable<Payment>> GetByNameAsync(string name);
        ValueTask<IEnumerable<Payment>> GetByDate(DateTime date);
    }
}
