using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IExpenseRepository
    {
        ValueTask AddAsync(Expense expense);
        ValueTask<Expense> GetByIdAsync(int id);
        ValueTask<IQueryable<Expense>> GetByCategoryAsync(SubCategory subCategory);
        ValueTask<IQueryable<Expense>> GetByDateAsync(DateTime date);
        ValueTask<IEnumerable<Expense>> GetAllAsync();
        ValueTask UpdateAsync(Expense expense);
        ValueTask DeleteAsync(int id);
    }
}
