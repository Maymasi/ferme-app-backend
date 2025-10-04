using Core.Entities;
namespace Core.Interfaces
{
    public interface IExpenseRepository
    {
        ValueTask AddAsync(Expense expense);
        ValueTask<Expense> GetByIdAsync(int id);
        ValueTask<IEnumerable<Expense>> GetByCategoryAsync(SubCategory subCategory);
        ValueTask<IEnumerable<Expense>> GetByDateAsync(DateTime date);
        ValueTask<IEnumerable<Expense>> GetAllAsync();
        ValueTask UpdateAsync(Expense expense);
        ValueTask DeleteAsync(int id);
    }
}
