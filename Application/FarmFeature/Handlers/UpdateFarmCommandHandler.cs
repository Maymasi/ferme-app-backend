using Application.FarmFeature.Commands;
using Application.Responses;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class UpdateFarmCommandHandler : IRequestHandler<UpdateFarmCommand, baseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public UpdateFarmCommandHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<baseCommandResponse> Handle(UpdateFarmCommand command, CancellationToken cancellationToken)
        {
            var response = new baseCommandResponse();
            var existingFarm = await _repository.GetByIdAsync(command.id);
            if (existingFarm == null)
            {
                response.success = false;
                response.message = "Farm not Found";
                return response;
            }
            _mapper.Map(command.FarmRequestDto, existingFarm);
            await _repository.UpdateAsync(existingFarm);
            await _repository.SaveChanges();

            response.success = true;
            response.message = "Farm updated Sucssefuly";
            return response;
        }
    }
}
