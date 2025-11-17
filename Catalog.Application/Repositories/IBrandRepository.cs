using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<ProductBrand>> GetAllBrands();
    }
}