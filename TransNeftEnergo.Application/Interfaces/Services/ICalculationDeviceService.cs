using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface ICalculationDeviceService
    {
        Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year);
    }
}
