using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.Features.Coupon.Commands.Delete
{
    public class DeleteDiscountCommand : IRequest<bool>
    {
        public string Code { get; set; }

        public DeleteDiscountCommand(string code)
        {
            Code = code;
        }
    }
}