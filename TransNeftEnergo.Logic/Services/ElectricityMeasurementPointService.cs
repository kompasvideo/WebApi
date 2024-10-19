using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;

namespace TransNeftEnergo.Logic.Services
{
    public class ElectricityMeasurementPointService(
        IElectricityMeasurementPointRepository electricityMeasurementPointRepository)
        : IElectricityMeasurementPointService
    {
        public async Task<ResponseStatus> Add(ElectricityMeasurementPointReq electricityMeasurementPointReq)
            => await electricityMeasurementPointRepository.Add(electricityMeasurementPointReq);        
    }
}
