using Application.FarmFeature.Commands;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class CreateFarmCommandHandler : IRequestHandler<CreateFarmCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public CreateFarmCommandHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<string> Handle(CreateFarmCommand command, CancellationToken cancellationToken)
        {

            var farmEntity = _mapper.Map<Farm>(command.farmRequestDto);
            await _repository.AddAsync(farmEntity);
            await _repository.SaveChanges();

            return farmEntity.id;
        }
    }
}
