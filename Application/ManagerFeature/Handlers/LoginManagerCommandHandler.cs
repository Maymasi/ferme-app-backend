using Application.DTOs.Responses;
using Application.ManagerFeature.Commands;
using Application.Security;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class LoginManagerCommandHandler : IRequestHandler<LoginManagerCommand, LoginResponse>
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;

        public LoginManagerCommandHandler(IManagerRepository managerRepository, IPasswordHasher passwordHasher, ITokenService tokenService)
        {
            _managerRepository = managerRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
        }

        public async Task<LoginResponse> Handle(LoginManagerCommand request, CancellationToken cancellationToken)
        {
            var existManager = await _managerRepository.GetByEmail(request.email);

            if (existManager == null)
                throw new InvalidCredentialException("Invalid login credentials.");

            var validPassword = _passwordHasher.Verify(request.password, existManager.password);

            if(!validPassword)
                throw new InvalidCredentialException("Invalid login credentials.");

            var token = _tokenService.CreateToken(existManager);

            return new LoginResponse
            {
                id = existManager.id,
                username = $"{existManager.firstName} {existManager.lastName}",
                Token = token
            };           
        }
    }
}
