using Catalog.Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Dtos
{
    public class ProductResponse
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = default!;

        [BsonElement("Name")]
        public string Name { get; set; } = default!;

        public string Summary { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string ImageFile { get; set; } = default!;

        public ProductBrand Brands { get; set; } = default!;
        public ProductType Types { get; set; } = default!;

        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }
    }
}