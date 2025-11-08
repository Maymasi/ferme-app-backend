using Application.ManagerFeature.Commands;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class DeleteManagerCommandHandler : IRequestHandler<DeleteManagerCommand, Unit>
    {
        private readonly IRepository<Manager> _repository; 

        public DeleteManagerCommandHandler(IRepository<Manager> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteManagerCommand command, CancellationToken cancellationToken)
        {
            var existManager = await _repository.GetByIdAsync(command.Id);

            if (existManager == null)
                throw new EntityNotFoundException("Manager", command.Id);

            await _repository.DeleteAsync(command.Id);
            await _repository.SaveChanges();

            return Unit.Value;
        }
    }
}
