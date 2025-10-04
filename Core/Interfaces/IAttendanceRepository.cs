using Core.Entities;
namespace Core.Interfaces
{
    public interface IAttendanceRepository
    {
        ValueTask<Attendance> GetByIdAsync(string id);
        ValueTask<IEnumerable<Attendance>> GetByDateAsync(DateTime date);
        ValueTask<IEnumerable<Attendance>> GetByEmployeeAsync(string EmployeeId);
        ValueTask AddAsync(Attendance attendance);
        ValueTask UpdateAsync(Attendance attendance);
        ValueTask DeleteAsync(string id);
        ValueTask<bool> ExistAsync(string EmployeeId, DateTime date);
        public int SaveChanges();
    }
}
