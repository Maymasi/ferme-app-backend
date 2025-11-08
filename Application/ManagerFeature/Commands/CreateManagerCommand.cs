using Application.DTOs.Requests;
using MediatR;

namespace Application.ManagerFeature.Commands
{
    public class CreateManagerCommand : IRequest<string>
    {
        public required ManagerRequestDto ManagerRequestDto { get; set; }
    }
}
