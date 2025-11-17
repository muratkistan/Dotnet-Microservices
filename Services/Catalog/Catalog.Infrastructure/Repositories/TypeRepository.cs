using Catalog.Application.Repositories;
using Catalog.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly IMongoCollection<ProductType> _types;

        public TypeRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _types = database.GetCollection<ProductType>(settings.Value.TypesCollectionName);
        }

        public async Task<IEnumerable<ProductType>> GetAllTypes()
        {
            return await _types.Find(_ => true).ToListAsync();
        }
    }
}