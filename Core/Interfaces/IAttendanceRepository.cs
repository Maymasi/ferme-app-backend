using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAttendanceRepository
    {
        ValueTask<Attendance> GetByIdAsync(string id);
        ValueTask<IQueryable<Attendance>> GetByDateAsync(DateTime date);
        ValueTask<IQueryable<Attendance>> GetByStudentAsync(string IdStudent);
        ValueTask AddAsync(Attendance attendance);
        ValueTask UpdateAsync(Attendance attendance);
        ValueTask DeleteAsync(string id);
        ValueTask<bool> ExistAsync(string studentId, DateTime date);
    }
}
