using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface IElectricityMeasurementPointRepository
    {
        public Task<ResponseStatus> Add(ElectricityMeasurementPointReq electricityMeasurementPointReq);
    }
}
