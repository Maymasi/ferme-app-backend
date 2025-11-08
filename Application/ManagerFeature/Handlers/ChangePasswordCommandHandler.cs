using Application.ManagerFeature.Commands;
using Application.Security;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, Unit>
    {
        private readonly IManagerRepository _repository;
        private readonly IPasswordHasher _passwordHasher;

        public ChangePasswordCommandHandler(IManagerRepository repository, IPasswordHasher passwordHasher)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
        }
        public async Task<Unit> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {

            var managerToUpdatePassword = await _repository.GetByIdAsync(request.Id);

            if (managerToUpdatePassword == null)
                throw new EntityNotFoundException("Manager", request.Id);

            if (!_passwordHasher.Verify(request.oldPassword, managerToUpdatePassword.password))
                throw new InvalidCredentialException("Old password is incorrect");

            managerToUpdatePassword.password = _passwordHasher.Hash(request.Password);
            await _repository.UpdateAsync(managerToUpdatePassword);
            await _repository.SaveChanges();

            return Unit.Value;
        }
    }
}
