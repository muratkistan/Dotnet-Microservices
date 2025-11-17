using Catalog.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Product.GetById
{
    public class GetProductByIdQuery : IRequest<ProductResponse>
    {
        public string Id { get; set; }

        public GetProductByIdQuery(string id)
        {
            Id = id;
        }
    }
}