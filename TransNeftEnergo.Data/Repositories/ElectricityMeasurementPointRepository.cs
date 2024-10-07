using AutoMapper;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class ElectricityMeasurementPointRepository (
        OrganizationDb _Db,
        IMapper mapper)
        : IElectricityMeasurementPointRepository
    {
        public async Task<ResponseStatus> Add(ElectricityMeasurementPointDto electricityMeasurementPointDto)
        {
            ElectricityMeasurementPoint electricityMeasurementPoint = mapper.Map<ElectricityMeasurementPoint>(electricityMeasurementPointDto);
            using (var transaction = _Db.Database.BeginTransaction())
            {
                await _Db.CurrentTransformers.AddAsync(electricityMeasurementPoint?.CurrentTransformer);
                await _Db.VoltageTransformers.AddAsync(electricityMeasurementPoint?.VoltageTransformer);
                await _Db.ElectricEnergyMeters.AddAsync(electricityMeasurementPoint?.ElectricEnergyMeter);
                await _Db.ElectricityMeasurementPoints.AddAsync(electricityMeasurementPoint);

                _Db.SaveChanges();

                await transaction.CommitAsync();

                return new ResponseStatus();
            }
        }
    }
}
