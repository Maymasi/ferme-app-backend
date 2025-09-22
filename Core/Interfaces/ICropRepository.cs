using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICropRepository
    {
        ValueTask AddAsync(Crop crop);
        ValueTask<Crop> GetByIdAsync(string id);
        ValueTask<IQueryable<Crop>> GetByYear(string year);
        ValueTask<IEnumerable<Crop>> GetAllAsync();
        ValueTask UpdateAsync(Crop crop);
        ValueTask DeleteAsync(string id);
    }
}
