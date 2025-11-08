using Core.Entities;
using System;
namespace Core.Interfaces
{
    public interface IManagerRepository : IRepository<Manager>
    {
        ValueTask<bool> ExistsByEmail(string email);
        ValueTask<Manager> GetByEmail(string email);
    }
}
