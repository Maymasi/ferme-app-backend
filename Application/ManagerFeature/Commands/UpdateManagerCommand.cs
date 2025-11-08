using Application.DTOs.Requests;
using MediatR;

namespace Application.ManagerFeature.Commands
{
    public class UpdateManagerCommand : IRequest<Unit>
    {
        public required ManagerRequestDto ManagerRequestDto { get; set; }
        public required string Id {get; set;}
    }
}
