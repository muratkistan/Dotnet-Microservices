using Catalog.Application.Repositories;
using Catalog.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        Action<MongoDbSettings> configureSettings)
        {
            services.Configure(configureSettings);
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IBrandRepository, BrandRepository>();
            services.AddSingleton<ITypeRepository, TypeRepository>();
            return services;
        }
    }
}