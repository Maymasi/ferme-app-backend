
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class AttendanceRepository : IAttendanceRepository
    {
        private ApplicationDbContext _context;
        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask AddAsync(Attendance attendance) =>
            await _context.Attendances.AddAsync(attendance);

        public async ValueTask DeleteAsync(string id)
        {
            var attendance = await _context.Attendances.FindAsync(id);
            _context.Attendances.Remove(attendance);
        }

        public async ValueTask<bool> ExistAsync(string employeeId, DateTime date)
        {
            var attendance =  _context.Attendances.Any(x => x.employeeId == employeeId && x.date == date);
            return attendance;
        }

        public async ValueTask<IEnumerable<Attendance>> GetByDateAsync(DateTime date)
        {
            var attendance = await _context.Attendances.Where(x => x.date == date).ToListAsync();
            return attendance;
        }

        public async ValueTask<Attendance> GetByIdAsync(string id)
        {
            var attendance = await _context.Attendances.FindAsync(id);
            return attendance;
        }

        public async ValueTask<IEnumerable<Attendance>> GetByEmployeeAsync(string EmployeeId)
        {
            var attendance = await _context.Attendances.Where(x => x.employeeId == EmployeeId).ToListAsync();
            return attendance;
        }

        public async ValueTask UpdateAsync(Attendance attendance) =>
            _context.Attendances.Update(attendance);
        public int SaveChanges() => _context.SaveChanges();
    }
}
