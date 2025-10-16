using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class AttendanceRepository : Repository<Attendance>, IAttendanceRepository 
    {
        public AttendanceRepository(ApplicationDbContext context) : base(context) {}

        public async ValueTask<bool> ExistAsync(string employeeId, DateTime date)
        {
            var attendance =  await _entity.AnyAsync(x => x.employeeId == employeeId && x.date == date);
            return attendance;
        }

        public async ValueTask<IEnumerable<Attendance>> GetByDateAsync(DateTime date)
        {
            var attendances = await _entity.Where(x => x.date == date).ToListAsync();
            return attendances;
        }


        public async ValueTask<IEnumerable<Attendance>> GetByEmployeeAsync(string employeeId)
        {
            var attendances = await _entity.Where(x => x.employeeId == employeeId).ToListAsync();
            return attendances;
        }

    }
}
