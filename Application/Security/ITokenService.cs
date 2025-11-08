using Core.Entities;

namespace Application.Security
{
    public interface ITokenService
    {
        public string CreateToken(Manager manager);
    }
}
