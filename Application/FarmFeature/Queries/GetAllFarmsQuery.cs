using Application.DTOs.Responses;
using MediatR;

namespace Application.FarmFeature.Queries
{
    public class GetAllFarmsQuery : IRequest<List<FarmResponseDto>>
    {
    }
}
