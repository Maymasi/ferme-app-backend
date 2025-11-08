using Application.DTOs.Responses;
using MediatR;

namespace Application.ManagerFeature.Commands
{
    public class LoginManagerCommand : IRequest<LoginResponse>
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
