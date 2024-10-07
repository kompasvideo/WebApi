using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface IObjectOfConsumptionRepository
    {
        public Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
        public Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
        public Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
    }
}
