using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Logic.Services
{
    public class CalculationDeviceService(
        ICalculationDeviceRepository calculationDeviceRepository)
        : ICalculationDeviceService
    {
        public async Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year)
        {
            return await calculationDeviceRepository.GetAllForYear(year);
        }
    }
}
