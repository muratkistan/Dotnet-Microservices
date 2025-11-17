using Catalog.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Product.GetByBrand
{
    public class GetProductByBrandQuery : IRequest<IList<ProductResponse>>
    {
        public string BrandName { get; set; }

        public GetProductByBrandQuery(string brandName)
        {
            BrandName = brandName;
        }
    }
}