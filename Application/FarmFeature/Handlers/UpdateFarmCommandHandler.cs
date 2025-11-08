using Application.FarmFeature.Commands;
using AutoMapper;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class UpdateFarmCommandHandler : IRequestHandler<UpdateFarmCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public UpdateFarmCommandHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<Unit> Handle(UpdateFarmCommand command, CancellationToken cancellationToken)
        {
            var existingFarm = await _repository.GetByIdAsync(command.id);

            if (existingFarm == null)
                throw new EntityNotFoundException("Farm", command.id);

            _mapper.Map(command.FarmRequestDto, existingFarm);
            await _repository.UpdateAsync(existingFarm);
            await _repository.SaveChanges();

            return Unit.Value;
        }
    }
}
