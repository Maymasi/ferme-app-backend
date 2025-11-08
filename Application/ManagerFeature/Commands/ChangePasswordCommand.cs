using MediatR;

namespace Application.ManagerFeature.Commands
{
    public class ChangePasswordCommand : IRequest<Unit>
    {
        public required string Id { get; set; }
        public required string Password { get; set; }
        public required string oldPassword { get; set; }
    }
}
