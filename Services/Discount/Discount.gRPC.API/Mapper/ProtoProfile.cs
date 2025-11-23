using AutoMapper;
using Discount.Application;
using Discount.Grpc.Protos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Discount.gRPC.API.Mapper
{
    internal class ProtoProfile : Profile
    {
        public ProtoProfile()
        {
            CreateMap<CouponResponse, CouponModel>().ReverseMap();
        }
    }
}