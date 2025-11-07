using Application.ManagerFeature.Commands;
using Application.Security;
using AutoMapper;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class CreateManagerCommandHandler : IRequestHandler<CreateManagerCommand,string>
    {
        private readonly IMapper _mapper;
        private readonly IManagerRepository _repository;
        private readonly IPasswordHasher _passwordHasher;

        public CreateManagerCommandHandler(IMapper mapper, IManagerRepository repository, IPasswordHasher passwordHasher)
        {
            _mapper = mapper;
            _repository = repository;
            _passwordHasher = passwordHasher;
        }

        public async Task<string> Handle(CreateManagerCommand command, CancellationToken cancellationToken)
        {
            var exist = await _repository.ExistsByEmail(command.ManagerRequestDto.email);
            if (exist)
                throw new EntityAlreadyExistsException("manager", command.ManagerRequestDto.email);

            command.ManagerRequestDto.password = _passwordHasher.Hash(command.ManagerRequestDto.password);
            var managerEntity = _mapper.Map<Manager>(command.ManagerRequestDto);
            await _repository.AddAsync(managerEntity);
            await _repository.SaveChanges();

            return managerEntity.id;
        }

    }
}
