using Application.DTOs.Requests;
using MediatR;

namespace Application.FarmFeature.Commands
{
    public class CreateFarmCommand : IRequest<string>
    {
        public required FarmRequestDto farmRequestDto { get; set; }
    }
}
