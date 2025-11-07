using Application.FarmFeature.Commands;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class DeleteFarmCommandHandler : IRequestHandler<DeleteFarmCommand, Unit>
    {
        private readonly IRepository<Farm> _repository;

        public DeleteFarmCommandHandler(IRepository<Farm> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteFarmCommand command, CancellationToken cancellationToken)
        {
            var existingFarm = await _repository.GetByIdAsync(command.id);

            if (existingFarm == null)
                throw new EntityNotFoundException("Farm", command.id);

             await _repository.DeleteAsync(command.id);
             await _repository.SaveChanges();

             return Unit.Value;
        }
    }
}
