using AutoMapper;
using Order.Application.Dtos;
using Order.Application.Features.Commands.Order.CreateOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEntity = Order.Domain.Entities.Order;

namespace Order.Application.Mapper
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderEntity, OrderResponse>().ReverseMap();
            CreateMap<OrderEntity, CreateOrderCommand>().ReverseMap();
        }
    }
}