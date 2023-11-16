using AutoMapper;
using StoreFront.Application.DTOs;
using StoreFront.Domain.Entities;

namespace StoreFront.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Product, ProductDto>()
                .ReverseMap()
                .ForMember(p => p.Id, opt => opt.Ignore());
            
         
        }
    }
}