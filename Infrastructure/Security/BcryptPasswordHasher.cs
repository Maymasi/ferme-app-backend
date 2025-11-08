using Application.Security;

namespace Infrastructure.Security
{
    public class BcryptPasswordHasher : IPasswordHasher
    {
        public string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
        }

        public bool Verify(string password, string Hashed)
        {
            return BCrypt.Net.BCrypt.Verify(password, Hashed);
        }
    }
}
