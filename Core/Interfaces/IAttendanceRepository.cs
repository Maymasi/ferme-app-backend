using Core.Entities;
namespace Core.Interfaces
{
    public interface IAttendanceRepository : IRepository<Attendance> 
    {
        ValueTask<IEnumerable<Attendance>> GetByDateAsync(DateTime date);
        ValueTask<IEnumerable<Attendance>> GetByEmployeeAsync(string EmployeeId);
        ValueTask<bool> ExistAsync(string EmployeeId, DateTime date);
    }
}
