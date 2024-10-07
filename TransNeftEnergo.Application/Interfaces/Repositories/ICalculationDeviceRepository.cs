using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface ICalculationDeviceRepository
    {
        Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year);
    }
}
