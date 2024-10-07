using Microsoft.Extensions.DependencyInjection;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Logic.Services;

namespace TransNeftEnergo.Logic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IElectricityMeasurementPointService, ElectricityMeasurementPointService>();
            services.AddTransient<ICalculationDeviceService, CalculationDeviceService>();
            services.AddTransient<IObjectOfConsumptionService, ObjectOfConsumptionService>();
            return services;
        }
    }
}
