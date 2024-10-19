using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Logic.Services
{
    public class CalculationDeviceService(
        ICalculationDeviceRepository calculationDeviceRepository)
        : ICalculationDeviceService
    {
        public async Task<IEnumerable<CalculationDeviceResp>> GetAllForYear(int year)
            => await calculationDeviceRepository.GetAllForYear(year);        
    }
}
