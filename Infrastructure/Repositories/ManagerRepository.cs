using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(ApplicationDbContext context) : base(context) { }
        public async ValueTask<bool> ExistsByEmail(string email)
        {
            var exist = await _entity.AnyAsync(a => a.email == email);
            return exist;
        }

        public async ValueTask<Manager> GetByEmailAsync(string email)
        {
            return await _entity.FirstOrDefaultAsync(a => a.email.ToLower() == email.ToLower());
        }
    }
}
