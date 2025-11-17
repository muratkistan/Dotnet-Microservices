using AutoMapper;
using Basket.Application.Features.Responses;
using Basket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Mapper
{
    public class BasketMappingProfile : Profile
    {
        public BasketMappingProfile()
        {
            CreateMap<Cart, CartResponse>().ReverseMap();
            CreateMap<CartItem, CartItemResponse>().ReverseMap();
        }
    }
}