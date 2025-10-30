using Core.Entities;
using System;
namespace Core.Interfaces
{
    public interface IManagerRespository : IRepository<Manager>
    {
        ValueTask<bool> ExistsByEmail(string email);
    }
}
