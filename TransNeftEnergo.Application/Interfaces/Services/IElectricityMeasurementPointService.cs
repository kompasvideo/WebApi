using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IElectricityMeasurementPointService
    {
        public Task<ResponseStatus> Add(ElectricityMeasurementPointReq electricityMeasurementPointReq);
    }
}
