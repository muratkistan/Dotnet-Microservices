using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface ITypeRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();
    }
}