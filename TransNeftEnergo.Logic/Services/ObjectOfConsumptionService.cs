using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Exceptions;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Logic.Services
{
    public class ObjectOfConsumptionService(
        IObjectOfConsumptionRepository objectOfConsumptionRepository)
        : IObjectOfConsumptionService
    {
        public async Task<IEnumerable<ElectricEnergyMeterResp>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            IEnumerable<ElectricEnergyMeterResp> result;
            try
            {
                result = await objectOfConsumptionRepository.GetAllMetersToEndVerificationDate(objectOfConsumptionReq);
            }
            catch (ObjectOfConsumptionException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ObjectOfConsumptionException("Ошибка при работе с БД");
            }
            return result;
        }

        public async Task<IEnumerable<VoltageTransformerResp>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            IEnumerable<VoltageTransformerResp> result;
            try
            {
                result = await objectOfConsumptionRepository.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionReq);
            }
            catch (ObjectOfConsumptionException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ObjectOfConsumptionException("Ошибка при работе с БД");
            }
            return result;
        }

        public async Task<IEnumerable<CurrentTransformerResp>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            IEnumerable<CurrentTransformerResp> result;
            try
            {
                result = await objectOfConsumptionRepository.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionReq);
            }
            catch (ObjectOfConsumptionException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ObjectOfConsumptionException("Ошибка при работе с БД");
            }
            return result;
        }
    }
}