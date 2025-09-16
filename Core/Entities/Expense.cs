using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Expense
    {
        public string id { get; set; }
        public DateTime expenseDate {  get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
        public string subCategoryId { get; set; }
        public string farmId { get; set; }
    }
}
