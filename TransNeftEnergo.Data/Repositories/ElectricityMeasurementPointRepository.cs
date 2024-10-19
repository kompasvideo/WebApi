using AutoMapper;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class ElectricityMeasurementPointRepository(
        OrganizationDb db,
        IMapper mapper)
        : IElectricityMeasurementPointRepository
    {
        // 1.	Добавить новую точку измерения с указанием счетчика, 
        // трансформатора тока и трансформатора напряжения.
        public async Task<ResponseStatus> Add(ElectricityMeasurementPointReq electricityMeasurementPointReq)
        {
            ElectricityMeasurementPoint electricityMeasurementPoint = mapper.Map<ElectricityMeasurementPoint>(electricityMeasurementPointReq);
            using (var transaction = db.Database.BeginTransaction())
            {
                await db.CurrentTransformers.AddAsync(electricityMeasurementPoint?.CurrentTransformer);
                await db.VoltageTransformers.AddAsync(electricityMeasurementPoint?.VoltageTransformer);
                await db.ElectricEnergyMeters.AddAsync(electricityMeasurementPoint?.ElectricEnergyMeter);
                await db.ElectricityMeasurementPoints.AddAsync(electricityMeasurementPoint);

                db.SaveChanges();

                await transaction.CommitAsync();

                return new ResponseStatus();
            }
        }
    }
}
