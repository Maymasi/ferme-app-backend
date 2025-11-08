
using Application.DTOs.Responses;
using Core.Entities;
using MediatR;

namespace Application.ManagerFeature.Queries
{
    public class GetAllManagersQuery : IRequest<List<ManagerResponseDto>>
    {
    }
}
