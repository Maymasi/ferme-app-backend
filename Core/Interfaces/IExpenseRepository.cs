using Core.Entities;
namespace Core.Interfaces
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        ValueTask<IEnumerable<Expense>> GetByCategoryAsync(SubCategory subCategory);
        ValueTask<IEnumerable<Expense>> GetByDateAsync(DateTime date);
    }
}
