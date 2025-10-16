using Application.FarmFeature.Commands;
using Application.Responses;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class CreateFarmCommandHandler : IRequestHandler<CreateFarmCommand, baseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public CreateFarmCommandHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<baseCommandResponse> Handle(CreateFarmCommand command, CancellationToken cancellationToken)
        {
            var response = new baseCommandResponse();

            var farmEntity = _mapper.Map<Farm>(command.farmRequestDto);
            await _repository.AddAsync(farmEntity);
            await _repository.SaveChanges();

            response.success = true;
            response.message = "Farm created successfully";

            return response;
        }
    }
}
