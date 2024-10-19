using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IObjectOfConsumptionService
    {
        public Task<IEnumerable<ElectricEnergyMeterResp>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
        public Task<IEnumerable<VoltageTransformerResp>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
        public Task<IEnumerable<CurrentTransformerResp>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq);
    }
}
