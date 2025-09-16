namespace Core.Entities
{
    public class Manager
    {
        public string id {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public ICollection<Farm> farms { get; set; }
    }
}
