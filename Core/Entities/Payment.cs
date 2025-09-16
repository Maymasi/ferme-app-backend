using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Payment
    {
        public string id { get; set; }
        public DateTime effectivePaymentDate { get; set; }
        public decimal amount { get; set; }
        public bool validated { get; set; }
        public DateTime periodStartDate { get; set; }
        public DateTime periodEndDate { get; set; }
        public string employeeId { get; set; }
        public Employee employee { get; set; }
    }
}
