using Application.ManagerFeature.Commands;
using AutoMapper;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class UpdateManagerCommandHandler : IRequestHandler<UpdateManagerCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IManagerRepository _repository;

        public UpdateManagerCommandHandler(IMapper mapper, IManagerRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateManagerCommand request, CancellationToken cancellationToken)
        {
            var managerToUpdate = await _repository.GetByIdAsync(request.Id);

            if (managerToUpdate == null)
                throw new EntityNotFoundException("Manager", request.Id);

            //Mapper ManagerRequestDto sur l'entité existante 
            //Met à jour les prop de 'managerToUpdate' selon les valeurs existantes dans ManagerRequestDto
            //sans ecraser les autres prop
            _mapper.Map(request.ManagerRequestDto, managerToUpdate);
            await _repository.UpdateAsync(managerToUpdate);
            await _repository.SaveChanges();

            return Unit.Value;
        }
    }
}
