using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
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
            return await objectOfConsumptionRepository.GetAllMetersToEndVerificationDate(objectOfConsumptionReq);
        }

        public async Task<IEnumerable<VoltageTransformerResp>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            return await objectOfConsumptionRepository.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionReq);
        }
        public async Task<IEnumerable<CurrentTransformerResp>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            return await objectOfConsumptionRepository.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionReq);
        }

    }
}
