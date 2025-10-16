using Application.DTOs.Requests;
using Application.Responses;
using MediatR;

namespace Application.FarmFeature.Commands
{
    public class CreateFarmCommand : IRequest<baseCommandResponse>
    {
        public required FarmRequestDto farmRequestDto { get; set; }
    }
}
