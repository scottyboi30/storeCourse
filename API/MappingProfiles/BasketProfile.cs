using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.MappingProfiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<CustomerBasketDto, CustomerBasket>().ReverseMap();
            CreateMap<BasketItemDto, BasketItem>().ReverseMap();
        }
    }
}
