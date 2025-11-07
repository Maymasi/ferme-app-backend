using Core.Entities;
using Application.DTOs.Requests;
using AutoMapper;

namespace Application.helper
{
    internal class AutoMapper : Profile
    {
        public AutoMapper() {
            //source : FarmRequestDto to destination : Farm
            CreateMap<FarmRequestDto, Farm>();
            CreateMap<Farm, FarmRequestDto>();
            CreateMap<ManagerRequestDto, Manager>();
            CreateMap<Manager, ManagerRequestDto>();
        }
    }
}
