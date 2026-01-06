using Discount.Application.Repositories;
using Discount.Domain.Entities;
using Discount.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Infrastructure.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Coupon> _dbSet;

        public CouponRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Coupon>();
        }

        public async Task<bool> CreateCouponAsync(Coupon coupon)
        {
            await _dbSet.AddAsync(coupon);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCouponAsync(string code)
        {
            var coupon = await _dbSet.FirstOrDefaultAsync(x => x.Code == code);
            if (coupon is null)
                return false;

            _dbSet.Remove(coupon);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Coupon> GetCouponByCodeAsync(string code)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Code == code)
               ?? new Coupon
               {
                   Code = code,
                   Amount = 0,
                   Percent = 0,
                   Description = "No discount",
                   IsActive = false
               };
        }

        public async Task<bool> UpdateCouponAsync(Coupon coupon)
        {
            var existing = await _dbSet
        .FirstOrDefaultAsync(x => x.Id == coupon.Id);

            if (existing == null)
                return false;

            existing.Code = coupon.Code;
            existing.Code = coupon.Code;
            existing.Amount = coupon.Amount;
            existing.Percent = coupon.Percent;
            existing.IsActive = coupon.IsActive;
            existing.Description = coupon.Description;
            existing.UsedCount = coupon.UsedCount;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}