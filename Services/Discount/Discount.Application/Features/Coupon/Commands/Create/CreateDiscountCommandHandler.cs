using AutoMapper;
using Discount.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Commands.Create
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, CouponResponse>
    {
        private readonly ICouponRepository _discountRepository;
        private readonly IMapper _mapper;

        public CreateDiscountCommandHandler(ICouponRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<CouponResponse> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            var coupon = _mapper.Map<Domain.Entities.Coupon>(request);
            await _discountRepository.CreateCouponAsync(coupon);
            var couponResponse = _mapper.Map<CouponResponse>(coupon);
            return couponResponse;
        }
    }
}