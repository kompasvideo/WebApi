using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IObjectOfConsumptionService
    {
        public Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
        public Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
        public Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto);
    }
}
