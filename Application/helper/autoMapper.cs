using Core.Entities;
using Application.DTOs.Requests;
using AutoMapper;

namespace Application.helper
{
    internal class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<FarmRequestDto, Farm>();
            //CreateMap<Farm, >();
        }
    }
}
