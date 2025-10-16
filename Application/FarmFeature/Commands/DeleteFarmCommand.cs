using Application.Responses;
using MediatR;

namespace Application.FarmFeature.Commands
{
    public class DeleteFarmCommand : IRequest<baseCommandResponse>
    {
        public string id { get; set; }
    }
}
