using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class ExpenseRepository: Repository<Expense>,IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext context):base(context){}

        public async ValueTask<IEnumerable<Expense>> GetByCategoryAsync(SubCategory subCategory)
        {
            var expenses = await _entity.Where(x=>x.subCategory == subCategory).ToListAsync();
            return expenses;
        }

        public async ValueTask<IEnumerable<Expense>> GetByDateAsync(DateTime date)
        {
            var expenses = await _entity.Where(x => x.expenseDate == date).ToListAsync();
            return expenses;
        }
    }
}
