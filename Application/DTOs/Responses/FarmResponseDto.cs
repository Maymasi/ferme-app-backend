namespace Application.DTOs.Responses
{
    public class FarmResponseDto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }
}
