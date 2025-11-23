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
        Task<Coupon> GetCoupon(string productName);

        Task<bool> CreateCoupon(Coupon coupon);

        Task<bool> UpdateCoupon(Coupon coupon);

        Task<bool> DeleteCoupon(string productName);
    }
}