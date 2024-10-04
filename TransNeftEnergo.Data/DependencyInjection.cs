using Microsoft.Extensions.DependencyInjection;
using TransNeftEnergo.Application.Interfaces;
using TransNeftEnergo.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TransNeftEnergo.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrganizationDb>(options =>
              options.UseSqlServer(
                  configuration["ConnectionStrings:EAConnectionString"],
                  b => b.MigrationsAssembly("TransNeftEnergo.WebAPI")));
            services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            services.AddTransient<OrganizationDb>();
            services.AddAutoMapper(typeof(AppMappingProfile));
            return services;
        }
    }
}
