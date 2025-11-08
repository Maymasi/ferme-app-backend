using MediatR;

namespace Application.FarmFeature.Commands
{
    public class DeleteFarmCommand : IRequest<Unit>
    {
        public string id { get; set; }
    }
}
