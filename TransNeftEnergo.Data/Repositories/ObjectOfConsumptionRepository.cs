using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;
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
        public async Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var oOfC = mapper.Map<ObjectOfConsumption>(objectOfConsumptionReq);
            var oOfCDb = await _Db.ObjectOfConsumptions.FirstOrDefaultAsync(i => i.Name == oOfC.Name);
            var result =  oOfCDb.ElectricityMeasurementPoints
                        .Select(empd => empd.ElectricEnergyMeter)
                        .Where(meter => meter != null 
                            && meter.VerificationDate < DateTime.Now)
                        .ToList();
            return mapper.Map<IEnumerable<ElectricEnergyMeterDto>>(result);
        }

        // 4. По указанному объекту потребления выбрать все 
        // трансформаторы напряжения с закончившимся сроком поверке.
        public async Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var oOfC = mapper.Map<ObjectOfConsumption>(objectOfConsumptionReq);
            var oOfCDb = await _Db.ObjectOfConsumptions.FirstOrDefaultAsync(i => i.Name == oOfC.Name);
            var result = oOfCDb.ElectricityMeasurementPoints
                        .Select(v => v.VoltageTransformer)
                        .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                        .ToList();
            return mapper.Map<IEnumerable<VoltageTransformerDto>>(result);
        }

        // 5. По указанному объекту потребления выбрать все 
        // трансформаторы тока с закончившимся сроком поверке.
        public async Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var oOfC = mapper.Map<ObjectOfConsumption>(objectOfConsumptionReq);
            var oOfCDb = await _Db.ObjectOfConsumptions.FirstOrDefaultAsync(i => i.Name == oOfC.Name);
            var result = oOfCDb.ElectricityMeasurementPoints
                        .Select(v => v.CurrentTransformer)
                        .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                        .ToList();
            return mapper.Map<IEnumerable<CurrentTransformerDto>>(result);
        }
    }
}
