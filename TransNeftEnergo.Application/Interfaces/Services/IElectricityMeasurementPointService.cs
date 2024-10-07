using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IElectricityMeasurementPointService
    {
        public Task<ResponseStatus> Add(ElectricityMeasurementPointDto electricityMeasurementPointDto);
    }
}
