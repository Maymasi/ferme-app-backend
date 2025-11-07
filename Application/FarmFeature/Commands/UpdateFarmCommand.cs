using Application.DTOs.Requests;
using MediatR;

namespace Application.FarmFeature.Commands
{
    public class UpdateFarmCommand : IRequest<Unit>
    {
        public string id {get; set;}
        public FarmRequestDto FarmRequestDto{ get; set; }
    }
}
