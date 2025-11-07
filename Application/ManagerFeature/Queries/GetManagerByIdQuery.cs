
using Application.DTOs.Responses;
using MediatR;

namespace Application.ManagerFeature.Queries
{
    public class GetManagerByIdQuery : IRequest<ManagerResponseDto>
    {
        public string Id { get; set; }
    }
}
