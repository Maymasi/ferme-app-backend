using Application.EmployeeFeature.Commands;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.EmployeeFeature.Handlers
{
    class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var existEmployee = await _employeeRepository.GetByIdAsync(request.id);

            if (existEmployee == null)
                throw new EntityNotFoundException("Employee", request.id);

            await _employeeRepository.DeleteAsync(request.id);
            await _employeeRepository.SaveChanges();
            return Unit.Value;
        }
    }
}
