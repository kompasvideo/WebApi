using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Logic.Services
{
    public class ObjectOfConsumptionService(
        IObjectOfConsumptionRepository objectOfConsumptionRepository)
        : IObjectOfConsumptionService
    {
        public async Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            return await objectOfConsumptionRepository.GetAllMetersToEndVerificationDate(objectOfConsumptionDto);
        }

        public async Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            return await objectOfConsumptionRepository.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionDto);
        }
        public async Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            return await objectOfConsumptionRepository.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionDto);
        }

    }
}
