using AutoMapper;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class ObjectOfConsumptionRepository(
        OrganizationDb _Db,
        IMapper mapper)
        : IObjectOfConsumptionRepository
    {
        // 3. По указанному объекту потребления выбрать все счетчики 
        // с закончившимся сроком поверке.
        public async Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            var result = await _Db.ObjectOfConsumptions.Where(t => t.AccountingPeriods.Any(
                i => i.StartDate.Year <= year && i.EndDate.Year >= year)).ToListAsync();
            return mapper.Map<IEnumerable<CalculationDeviceDto>>(result);

            throw new NotImplementedException();
        }

        // 4. По указанному объекту потребления выбрать все 
        // трансформаторы напряжения с закончившимся сроком поверке.
        public async Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            throw new NotImplementedException();
        }

        // 5. По указанному объекту потребления выбрать все 
        // трансформаторы тока с закончившимся сроком поверке.
        public async Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            throw new NotImplementedException();
        }
    }
}
