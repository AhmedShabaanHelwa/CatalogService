using Catalog.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddCatalogContext(this IServiceCollection services, string connectionString)
        {
             services.AddEntityFrameworkSqlServer();
            services.AddDbContext<CatalogContext>(
                contextOptions => contextOptions.UseSqlServer(connectionString,
                                serverOptions =>
                                {
                                    serverOptions.MigrationsAssembly(
                                        typeof(Startup)
                                        .GetTypeInfo()
                                        .Assembly
                                        .GetName()
                                        .Name);
                                } // end of serverOptions
                        ) // End of UseSqlServer
                );

            return services;
        }
    }
}
