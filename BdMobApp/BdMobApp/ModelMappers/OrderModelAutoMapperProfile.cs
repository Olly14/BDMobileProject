using AutoMapper;
using Bd.MobileApi.Data.Management.DtoModels;
using BdMobApp.Models;

namespace BdMobApp.ModelMappers
{
    public class OrderModelAutoMapperProfile : Profile
    {
        public OrderModelAutoMapperProfile()
        {
            CreateMap<OrderDto, OrderModel>().ReverseMap();
            CreateMap<OrderItemDto, OrderItemModel>().ReverseMap();
        }
    }
}
