using Core.Enums;

namespace Core.Entities
{
    public class Employee
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public PaymentType defaultPaymentType { get; set; }
        public decimal defaultAmount {  get; set; }
        public DateTime cycleStartDate { get; set; } 
        public string farmId { get; set; }

    }
}
