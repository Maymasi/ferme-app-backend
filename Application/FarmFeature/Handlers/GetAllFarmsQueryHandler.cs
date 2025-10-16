using Application.DTOs.Responses;
using Application.FarmFeature.Queries;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.FarmFeature.Handlers
{
    public class GetAllFarmsQueryHandler : IRequestHandler<GetAllFarmsQuery, List<FarmResponseDto>>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Farm> _repository;

        public GetAllFarmsQueryHandler(IMapper mapper, IRepository<Farm> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<List<FarmResponseDto>> Handle(GetAllFarmsQuery query, CancellationToken cancellationToken)
        {
            var farms = await _repository.GetAllAsync();
            var farmResponseDtos = _mapper.Map<List<FarmResponseDto>>(farms);
            return farmResponseDtos;
        }
}
