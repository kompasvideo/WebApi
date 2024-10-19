using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface ICalculationDeviceService
    {
        Task<IEnumerable<CalculationDeviceResp>> GetAllForYear(int year);
    }
}
