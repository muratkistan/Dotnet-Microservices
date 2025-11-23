using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application
{
    public class CouponResponse
    {
        public int Id { get; set; }

        public string Code { get; set; } = default!;

        public string ProductName { get; set; } = string.Empty;

        public double Amount { get; set; }

        public int? Percent { get; set; }

        public bool IsActive { get; set; } = true;
    }
}