using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RP.Application.Interfaces;
using RP.Persistence.Context;
using RP.Persistence.Repositories;

namespace RP.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DatabaseDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(DatabaseDbContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient<IStoreRepository, StoreRepository>();
            #endregion
        }
    }
}
