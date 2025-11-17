using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string ProductsCollectionName { get; set; } = "products";
        public string BrandsCollectionName { get; set; } = "brands";
        public string TypesCollectionName { get; set; } = "types";
    }
}