using API.DTOs;
using API.Helpers;
using AutoMapper;
using Core.Entities;

namespace API.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() => CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
    }
}
