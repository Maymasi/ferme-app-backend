
namespace Application.Responses
{
    public class baseCommandResponse
    {
        public int id {  get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public List<string> errors { get; set; }
    }
}
