using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Commands.Update
{
    public class UpdateDiscountCommand : IRequest<CouponResponse>
    {
        public int Id { get; set; }

        public string Code { get; set; } = default!;
        public string ProductName { get; set; } = string.Empty;

        public double Amount { get; set; }
        public int? Percent { get; set; }

        public bool IsActive { get; set; }
    }
}