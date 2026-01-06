using Discount.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Repositories
{
    public interface ICouponRepository
    {
        Task<Coupon> GetCouponByCodeAsync(string code);

        Task<bool> CreateCouponAsync(Coupon coupon);

        Task<bool> UpdateCouponAsync(Coupon coupon);

        Task<bool> DeleteCouponAsync(string productName);
    }
}