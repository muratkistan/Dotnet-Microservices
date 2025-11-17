using Catalog.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Product.GetByName
{
    public class GetProductByNameQuery : IRequest<IList<ProductResponse>>
    {
        public string Name { get; set; }

        public GetProductByNameQuery(string name)
        {
            Name = name;
        }
    }
}