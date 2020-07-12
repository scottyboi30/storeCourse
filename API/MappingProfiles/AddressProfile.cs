using API.DTOs;
using AutoMapper;
using Core.Entities.Identity;

namespace API.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Core.Entities.Identity.Address, AddressDto>().ReverseMap();
            CreateMap<AddressDto, Core.Entities.OrderAggregate.Address>().ReverseMap();
        }
    }
}
