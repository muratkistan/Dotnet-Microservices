using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discount.Domain.Entities
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = default!;

        public double Amount { get; set; }

        public int? Percent { get; set; }

        public bool IsActive { get; set; } = true;

        public int UsedCount { get; set; } = 0;

        [MaxLength(200)]
        public string? Description { get; set; }

        public int ProductTypeId { get; set; } = 0;
    }
}