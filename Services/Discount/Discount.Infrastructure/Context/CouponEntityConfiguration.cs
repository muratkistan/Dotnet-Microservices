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

            builder.Property(c => c.Id)
                .UseIdentityColumn();

            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(c => c.Code)
                .IsUnique();

            builder.Property(c => c.ProductName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.Percent)
                .IsRequired(false);

            builder.Property(c => c.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(c => c.UsedCount)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired(false);
        }
    }
}