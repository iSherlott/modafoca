using mf.domain.Repositories;
using mf.infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mf.infra.Configuration
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(b => b.UseNpgsql(connectionString));

            return services;
        }
    }
}