namespace Core.Exceptions
{
    public class InvalidCredentialException : Exception
    {
        public InvalidCredentialException() { }
        public InvalidCredentialException(string message) : base(message) {}
    }
}
