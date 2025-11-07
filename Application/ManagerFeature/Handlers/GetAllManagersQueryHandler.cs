using Application.DTOs.Responses;
using Application.ManagerFeature.Queries;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class GetAllManagersQueryHandler : IRequestHandler<GetAllManagersQuery, List<ManagerResponseDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Manager> _repository;

        public GetAllManagersQueryHandler(IMapper mapper, IRepository<Manager> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<ManagerResponseDto>> Handle(GetAllManagersQuery request, CancellationToken cancellationToken)
        {
            var managers = await _repository.GetAllAsync();
            var managerResponseDtos = _mapper.Map<List<ManagerResponseDto>>(managers);
            return managerResponseDtos;
        }
    }
}
