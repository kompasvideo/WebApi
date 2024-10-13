using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;

namespace TransNeftEnergo.Logic.Services
{
    public class ObjectOfConsumptionService(
        IObjectOfConsumptionRepository objectOfConsumptionRepository)
        : IObjectOfConsumptionService
    {
        public async Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            return await objectOfConsumptionRepository.GetAllMetersToEndVerificationDate(objectOfConsumptionReq);
        }

        public async Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            return await objectOfConsumptionRepository.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionReq);
        }
        public async Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            return await objectOfConsumptionRepository.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionReq);
        }

    }
}
