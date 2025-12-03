using Application.DTOs.Requests;
using MediatR;

namespace Application.EmployeeFeature.Commands
{
    internal class CreateEmployeeCommand : IRequest<Unit>
    {
        public required EmployeeRequestDto EmployeeRequest { get; set; }
    }
}
