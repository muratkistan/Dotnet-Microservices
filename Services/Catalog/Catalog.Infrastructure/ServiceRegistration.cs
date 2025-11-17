using Catalog.Application.Repositories;
using Catalog.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>(configuration.GetSection("TokenOption"));

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IBrandRepository, BrandRepository>();
            services.AddSingleton<ITypeRepository, TypeRepository>();

            return services;
        }
    }
}