using MediatR;

namespace Application.ManagerFeature.Commands
{
    public class DeleteManagerCommand : IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
