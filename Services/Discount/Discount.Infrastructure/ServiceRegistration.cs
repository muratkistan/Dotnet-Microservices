using Discount.Application.Repositories;
using Discount.Infrastructure.Context;
using Discount.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServicesExt(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreConnection"),
                                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName))

            );

            services.AddScoped<ICouponRepository, CouponRepository>();
        }
    }
}