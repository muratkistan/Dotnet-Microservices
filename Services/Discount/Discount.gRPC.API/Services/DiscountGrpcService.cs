using AutoMapper;
using Discount.Application.Features.Coupon.Commands.Create;
using Discount.Application.Features.Coupon.Commands.Delete;
using Discount.Application.Features.Coupon.Commands.Update;
using Discount.Application.Features.Coupon.Queries;
using Discount.gRPC.API;
using Discount.Grpc.Protos;
using Grpc.Core;
using MediatR;

namespace Discount.gRPC.API.Services
{
    public class DiscountGrpcService : DiscountProtoService.DiscountProtoServiceBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public DiscountGrpcService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public override async Task<CouponModel> GetDiscount(GetDiscountRequest request, ServerCallContext context)
        {
            var query = new GetDiscountQuery(request.Code);
            var result = await _mediator.Send(query);
            return _mapper.Map<CouponModel>(result);
        }

        public override async Task<CouponModel> CreateDiscount(CreateDiscountRequest request, ServerCallContext context)
        {
            var cmd = new CreateDiscountCommand
            {
                Code = request.Coupon.Code,
                Amount = request.Coupon.Amount,
                Percent = request.Coupon.Percent,
                IsActive = request.Coupon.IsActive
            };
            var result = await _mediator.Send(cmd);
            return _mapper.Map<CouponModel>(result);
        }

        public override async Task<CouponModel> UpdateDiscount(UpdateDiscountRequest request, ServerCallContext context)
        {
            var cmd = new UpdateDiscountCommand
            {
                Id = request.Coupon.Id,
                Code = request.Coupon.Code,
                Amount = request.Coupon.Amount,
                IsActive = request.Coupon.IsActive,
            };
            var result = await _mediator.Send(cmd);
            return _mapper.Map<CouponModel>(result);
        }

        public override async Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
        {
            var cmd = new DeleteDiscountCommand(request.Code);
            var deleted = await _mediator.Send(cmd);
            var response = new DeleteDiscountResponse
            {
                Success = deleted
            };
            return response;
        }
    }
}