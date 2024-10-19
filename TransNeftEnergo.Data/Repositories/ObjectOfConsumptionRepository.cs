using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class ObjectOfConsumptionRepository(
        OrganizationDb _Db,
        IMapper mapper)
        : IObjectOfConsumptionRepository
    {
        // 3. По указанному объекту потребления выбрать все счетчики 
        // с закончившимся сроком поверке.
        public async Task<IEnumerable<ElectricEnergyMeterResp>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
            => mapper.Map<ElectricEnergyMeter[], IEnumerable<ElectricEnergyMeterResp>>(
                (await _Db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.ElectricEnergyMeter)
                .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                .ToListAsync())
                .Select(empd => empd.ElectricEnergyMeter)
                .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                .ToArray());

        // 4. По указанному объекту потребления выбрать все 
        // трансформаторы напряжения с закончившимся сроком поверке.
        public async Task<IEnumerable<VoltageTransformerResp>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
            => mapper.Map<VoltageTransformer[], IEnumerable<VoltageTransformerResp>>(
                (await _Db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.VoltageTransformer)
                .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                .ToListAsync())
                .Select(v => v.VoltageTransformer)
                .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                .ToArray());

        // 5. По указанному объекту потребления выбрать все 
        // трансформаторы тока с закончившимся сроком поверке.
        public async Task<IEnumerable<CurrentTransformerResp>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
            => mapper.Map<CurrentTransformer[], IEnumerable<CurrentTransformerResp>>(
                (await _Db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.CurrentTransformer)
                .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                .ToListAsync())
                .Select(v => v.CurrentTransformer)
                .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                .ToArray());
    }
}
