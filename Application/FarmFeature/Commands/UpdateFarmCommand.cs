using Application.DTOs.Requests;
using Application.Responses;
using MediatR;

namespace Application.FarmFeature.Commands
{
    public class UpdateFarmCommand : IRequest<baseCommandResponse>
    {
        public string id {get; set;}
        public FarmRequestDto FarmRequestDto{ get; set; }
    }
}
