using Core.Entities;
using Core.Enums;

namespace Application.DTOs.Requests
{
    public class EmployeeRequestDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public PaymentType defaultPaymentType { get; set; }
        public decimal defaultAmount { get; set; }
        public DateTime cycleStartDate { get; set; }
        public string farmId { get; set; }
    }
}
