using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Commands.Create
{
    public class CreateDiscountCommand : IRequest<CouponResponse>
    {
        public string Code { get; set; } = default!;
        public double Amount { get; set; }
        public int? Percent { get; set; }
        public bool IsActive { get; set; }
    }
}