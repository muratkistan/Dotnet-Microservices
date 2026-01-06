using Discount.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Queries
{
    public class GetDiscountQueryHandler : IRequestHandler<GetDiscountQuery, CouponResponse>
    {
        private readonly ICouponRepository _discountRepository;

        public GetDiscountQueryHandler(ICouponRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<CouponResponse> Handle(GetDiscountQuery request, CancellationToken cancellationToken)
        {
            var coupon = await _discountRepository.GetCouponByCodeAsync(request.Code);
            if (coupon == null)
            {
                return null;
            }
            var couponModel = new CouponResponse
            {
                Amount = coupon.Amount,
                Code = coupon.Code,
                Percent = coupon.Percent,
                IsActive = coupon.IsActive
            };
            return couponModel;
        }
    }
}