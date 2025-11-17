using Catalog.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Context
{
    public class CatalogContext : ICatalogContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<Product> Products { get; }
        public IMongoCollection<ProductBrand> Brands { get; }
        public IMongoCollection<ProductType> Types { get; }

        public CatalogContext(IConfiguration configuration)
        {
            string connectionString = configuration.GetSection("DatabaseSettings:ConnectionString").Value;
            string databaseName = configuration.GetSection("DatabaseSettings:DatabaseName").Value;
            string brandsCollection = configuration.GetSection("DatabaseSettings:BrandsCollection").Value;
            string typesCollection = configuration.GetSection("DatabaseSettings:TypesCollection").Value;
            string productsCollection = configuration.GetSection("DatabaseSettings:CollectionName").Value;

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            Brands = database.GetCollection<ProductBrand>(brandsCollection);
            Types = database.GetCollection<ProductType>(typesCollection);
            Products = database.GetCollection<Product>(productsCollection);
        }
    }
}