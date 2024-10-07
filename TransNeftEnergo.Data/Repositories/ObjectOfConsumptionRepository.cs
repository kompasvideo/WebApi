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
        public async Task<IEnumerable<ElectricEnergyMeterDto>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            _Db.ObjectOfConsumptions.Where(m => m.);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VoltageTransformerDto>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<CurrentTransformerDto>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            throw new NotImplementedException();
        }
    }
}
