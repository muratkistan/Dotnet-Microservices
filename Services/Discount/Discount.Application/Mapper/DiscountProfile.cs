using AutoMapper;
using Discount.Application.Features.Coupon.Commands.Create;
using Discount.Application.Features.Coupon.Commands.Update;
using Discount.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponResponse>();
            CreateMap<CreateDiscountCommand, Coupon>();
            CreateMap<UpdateDiscountCommand, Coupon>();
        }
    }
}