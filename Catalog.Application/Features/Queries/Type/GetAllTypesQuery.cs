using Catalog.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Type
{
    public class GetAllTypesQuery : IRequest<IList<TypeResponse>>
    {
    }
}