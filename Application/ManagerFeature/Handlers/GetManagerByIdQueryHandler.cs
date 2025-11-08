using Application.DTOs.Responses;
using Application.ManagerFeature.Queries;
using AutoMapper;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.ManagerFeature.Handlers
{
    public class GetManagerByIdQueryHandler : IRequestHandler<GetManagerByIdQuery, ManagerResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IManagerRepository _repository;

        public GetManagerByIdQueryHandler(IMapper mapper, IManagerRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ManagerResponseDto> Handle(GetManagerByIdQuery request, CancellationToken cancellationToken)
        {
            var managerEntity = await _repository.GetByIdAsync(request.Id);

            if (managerEntity == null)
                throw new EntityNotFoundException("Manager", request.Id);

            var managerDto = _mapper.Map<ManagerResponseDto>(managerEntity);
            return managerDto;
        }
    }
}
