using Catalog.Application.Dtos;
using Catalog.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Product.GetAll
{
    public class GetAllProductsQuery : IRequest<Pagination<ProductResponse>>
    {
        public CatalogSpecParams CatalogSpecParams { get; set; }

        public GetAllProductsQuery(CatalogSpecParams catalogSpecParams)
        {
            CatalogSpecParams = catalogSpecParams;
        }
    }
}