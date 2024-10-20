using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Exceptions;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Logic.Services
{
    public class CalculationDeviceService(
        ICalculationDeviceRepository calculationDeviceRepository)
        : ICalculationDeviceService
    {
        public async Task<IEnumerable<CalculationDeviceResp>> GetAllForYear(int year)
        {
            IEnumerable<CalculationDeviceResp> result;
            try
            {
                result = await calculationDeviceRepository.GetAllForYear(year);
            }
            catch (CalculationDeviceException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new CalculationDeviceException("Ошибка при работе с БД");
            }
            return result;
        }
    }
}
