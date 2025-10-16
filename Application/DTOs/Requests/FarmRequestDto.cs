namespace Application.DTOs.Requests
{
    public class FarmRequestDto
    {
        public string name { get; set; }
        public string address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }
}
