using Application.FarmFeature.Commands;
using Application.Responses;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class DeleteFarmCommandHandler : IRequestHandler<DeleteFarmCommand, baseCommandResponse>
    {
        private readonly IRepository<Farm> _repository;

        public DeleteFarmCommandHandler(IRepository<Farm> repository)
        {
            _repository = repository;
        }
        public async Task<baseCommandResponse> Handle(DeleteFarmCommand command, CancellationToken cancellationToken)
        {
            var response = new baseCommandResponse();
            var existingFarm = await _repository.GetByIdAsync(command.id);

            if (existingFarm == null)
            {
                response.success = false;
                response.message = "Farm not Found";
                return response;
            }

             await _repository.DeleteAsync(command.id);
             await _repository.SaveChanges();

             response.success = true;
             response.message = "Farm deleted successfuly";
             return response;
        }
    }
}
