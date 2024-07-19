using AutoMapper;

using Application.Order.DTOs;
using Application.Product.DTOs;
using Domain.Order.Entities;
using Domain.Product.Entities;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Order.Entities.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();

            CreateMap<Domain.Product.Entities.Product, ProductDto>().ReverseMap();
        }
    }
}
