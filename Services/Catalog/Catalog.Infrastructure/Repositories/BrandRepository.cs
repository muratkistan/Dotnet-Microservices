using Catalog.Application.Repositories;
using Catalog.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IMongoCollection<ProductBrand> _brands;

        public BrandRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _brands = database.GetCollection<ProductBrand>(settings.Value.BrandsCollectionName);
        }

        public async Task<IEnumerable<ProductBrand>> GetAllBrands()
        {
            return await _brands.Find(_ => true).ToListAsync();
        }
    }
}