using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface ICalculationDeviceRepository
    {
        Task<IEnumerable<CalculationDeviceResp>> GetAllForYear(int year);
    }
}
