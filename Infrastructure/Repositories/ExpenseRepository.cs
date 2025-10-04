
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class ExpenseRepository:IExpenseRepository
    {
        private ApplicationDbContext _context;
        public ExpenseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask AddAsync(Expense expense) =>
            await _context.Expenses.AddAsync(expense);

        public async ValueTask DeleteAsync(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            _context.Expenses.Remove(expense);
        }

        public async ValueTask<IEnumerable<Expense>> GetAllAsync() =>
             await _context.Expenses.ToListAsync();

        public async ValueTask<IEnumerable<Expense>> GetByCategoryAsync(SubCategory subCategory)
        {
            var oData = await _context.Expenses.Where(x=>x.subCategory == subCategory).ToListAsync();
            return oData;
        }

        public async ValueTask<IEnumerable<Expense>> GetByDateAsync(DateTime date)
        {
            var oData = await _context.Expenses.Where(x => x.expenseDate == date).ToListAsync();
            return oData;
        }

        public async ValueTask<Expense> GetByIdAsync(int id) =>
            await _context.Expenses.FindAsync(id);

        public async ValueTask UpdateAsync(Expense expense) =>
            _context.Expenses.Update(expense);
        public int SaveChanges() => _context.SaveChanges();
    }
}
