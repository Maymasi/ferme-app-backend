namespace Core.Entities
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public ICollection<SubCategory> subCategories { get; set; }
    }
}
