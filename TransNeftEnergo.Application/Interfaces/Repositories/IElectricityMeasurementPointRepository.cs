using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface IElectricityMeasurementPointRepository
    {
        public Task<ResponseStatus> Add(ElectricityMeasurementPointDto electricityMeasurementPointDto);
    }
}
