namespace Core.Entities
{
    public class SubCategory
    {
        public string id { get; set; }
        public string name { get; set; }
        public string categoryId { get; set; }
        public Category category { get; set; }
        public ICollection<Expense> expenses { get; set; }
    }
}
