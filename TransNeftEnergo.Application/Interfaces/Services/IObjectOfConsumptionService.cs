using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IObjectOfConsumptionService
    {
        public Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
        public Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
        public Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
    }
}
