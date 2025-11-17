using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Entities
{
    public class Product : BaseEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; } = default!;

        public string Summary { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? ImageFile { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }

        [BsonIgnore]
        public ProductBrand Brands { get; set; } = default;

        [BsonIgnore]
        public ProductType Types { get; set; } = default;
    }
}