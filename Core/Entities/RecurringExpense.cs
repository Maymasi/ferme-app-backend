namespace Core.Entities
{
    public class RecurringExpense : Expense
    {
        public string id {  get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string expenseId { get; set; }
        public Expense expense { get; set; }
    }
}
