using Discount.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Infrastructure.Context
{
    public class CouponEntityConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("Coupons");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => new { c.Code, c.IsActive })
            .IsUnique()
            .HasFilter("\"IsActive\" = true");

            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .HasMaxLength(200);
        }
    }
}