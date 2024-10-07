using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class CalculationDeviceRepository(
        OrganizationDb _Db)
        : ICalculationDeviceRepository
    {
        public async Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year)
        {
            //_Db.CalculationDevices.Where(t => t.AccountingPeriods.)
            throw new NotImplementedException();
        }
    }
}
