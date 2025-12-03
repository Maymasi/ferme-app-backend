using MediatR;

namespace Application.EmployeeFeature.Commands
{
    internal class DeleteEmployeeCommand : IRequest<Unit>
    {
        public string id {  get; set; }
    }
}
