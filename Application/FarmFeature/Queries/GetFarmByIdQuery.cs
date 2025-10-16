using Application.DTOs.Responses;
using MediatR;

namespace Application.FarmFeature.Queries
{
    public class GetFarmByIdQuery : IRequest<FarmResponseDto>
    {
        public string id {  get; set; }
    }
}
