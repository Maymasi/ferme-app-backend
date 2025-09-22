using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class QuantityExpense : Expense
    {
        public string id { get; set; }
        public decimal quantity { get; set; }
        public decimal initPrice { get; set; }
        public string expenseId { get; set; }
        public Expense expense { get; set; }
    }
}
