using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Exceptions;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Logic.Services
{
    public class ElectricityMeasurementPointService(
        IElectricityMeasurementPointRepository electricityMeasurementPointRepository)
        : IElectricityMeasurementPointService
    {
        public async Task<ResponseStatus> Add(ElectricityMeasurementPointReq electricityMeasurementPointReq)
        {
            ResponseStatus result;
            try
            {
                result = await electricityMeasurementPointRepository.Add(electricityMeasurementPointReq);
            }
            catch (ElectricityMeasurementPointException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ElectricityMeasurementPointException("Ошибка при работе с БД");
            }
            return result;
        }
    }
}
