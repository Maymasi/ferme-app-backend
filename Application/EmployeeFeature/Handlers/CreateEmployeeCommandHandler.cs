using Application.EmployeeFeature.Commands;
using AutoMapper;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.EmployeeFeature.Handlers
{
    internal class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var existEmployee = await _employeeRepository.GetByFullNameAsync(request.EmployeeRequest.firstName, request.EmployeeRequest.lastName);

            if (existEmployee != null)
                throw new EntityAlreadyExistsException($"Employee with name {request.EmployeeRequest.firstName} {request.EmployeeRequest.lastName} already exists");

            var employeeEntity = _mapper.Map<Employee>(request.EmployeeRequest);
            await _employeeRepository.AddAsync(employeeEntity);
            await _employeeRepository.SaveChanges();
            return Unit.Value;          
        }
    }
}
