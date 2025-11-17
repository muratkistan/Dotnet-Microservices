using Catalog.Domain;
using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Repositories
{
    public interface IProductRepository
    {
        Task<Pagination<Product>> GetProducts(CatalogSpecParams catalogSpecParams);

        Task<Product> GetProduct(string id);

        Task<IEnumerable<Product>> GetProductsByName(string name);

        Task<IEnumerable<Product>> GetProductsByBrand(string brandName);

        Task<Product> CreateProduct(Product product);

        Task<bool> UpdateProduct(Product product);

        Task<bool> DeleteProduct(string id);
    }
}