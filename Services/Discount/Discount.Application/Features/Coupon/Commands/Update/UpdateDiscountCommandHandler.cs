using AutoMapper;
using Discount.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Commands.Update
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, CouponResponse>
    {
        private readonly ICouponRepository _discountRepository;
        private readonly IMapper _mapper;

        public UpdateDiscountCommandHandler(ICouponRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<CouponResponse> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
        {
            var coupon = _mapper.Map<Domain.Entities.Coupon>(request);
            await _discountRepository.UpdateCouponAsync(coupon);
            var couponModel = _mapper.Map<CouponResponse>(coupon);
            return couponModel;
        }
    }
}