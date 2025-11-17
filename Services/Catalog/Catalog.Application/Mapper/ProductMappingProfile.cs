using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Application.Features.Commands.Product.CreateProduct;
using Catalog.Application.Features.Queries.Product.GetAll;
using Catalog.Domain;
using Catalog.Domain.Entities;

namespace Catalog.Application.Mapper
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            //CreateMap<ProductBrand, BrandResponse>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();
            //CreateMap<ProductType, TypesResponse>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Pagination<Product>, Pagination<ProductResponse>>().ReverseMap();
        }
    }
}