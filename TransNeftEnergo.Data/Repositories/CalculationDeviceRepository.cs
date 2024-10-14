using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class CalculationDeviceRepository(
        OrganizationDb _Db,
        IMapper mapper)
        : ICalculationDeviceRepository
    {
        // 2.	Выбрать все расчетные приборы учета в 2018 году.
        public async Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year)
        => mapper.Map<CalculationDevice[], IEnumerable<CalculationDeviceDto>>(await _Db.CalculationDevices.Where(
            t => t.AccountingPeriods.Any(
            i => i.StartDate.Value.Year <= year && i.EndDate.Value.Year >= year)).ToArrayAsync());
    }
}
