namespace Core.Exceptions
{
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException() { }
        public EntityAlreadyExistsException(string message) : base(message) {}
        public EntityAlreadyExistsException(string name, object key) : base($"Entity \"{name}\" ({key}) already exist") { }

    }
}
