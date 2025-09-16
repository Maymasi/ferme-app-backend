namespace Core.Entities
{
    public class Farm
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public ICollection<Manager> managers { get; set; }
        public ICollection<Employee> employees { get; set; }
        public ICollection<Crop> crops { get; set; }
        public ICollection<Expense> expenses { get; set; }
    }
}
