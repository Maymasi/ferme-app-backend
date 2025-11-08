using Application.DTOs.Responses;
using Application.FarmFeature.Queries;
using AutoMapper;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class GetFarmByIdQueryHandler : IRequestHandler<GetFarmByIdQuery, FarmResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public GetFarmByIdQueryHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<FarmResponseDto> Handle(GetFarmByIdQuery query,CancellationToken cancellationToken)
        {
            var farmEntity = await _repository.GetByIdAsync(query.id);

            if (farmEntity == null)
                throw new EntityNotFoundException("Farm",query.id);

            var farmDto = _mapper.Map<FarmResponseDto>(farmEntity);
            return farmDto;
        }
    }
}
