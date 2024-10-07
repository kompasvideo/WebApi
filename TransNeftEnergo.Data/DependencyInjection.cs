using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Data.Repositories;

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
            services.AddTransient<OrganizationDb>();
            services.AddAutoMapper(typeof(AppMappingProfile));

            services.AddTransient<IOrganizationRepository, OrganizationRepository>();
            services.AddTransient<IElectricityMeasurementPointRepository, ElectricityMeasurementPointRepository>();
            services.AddTransient<ICalculationDeviceRepository, CalculationDeviceRepository>();
            services.AddTransient<IObjectOfConsumptionRepository, ObjectOfConsumptionRepository>();

            return services;
        }
    }
}
