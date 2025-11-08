namespace Application.DTOs.Responses
{
    public class ManagerResponseDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public List<string> farms { get; set; }
    }
}
