using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class CalculationDeviceRepository(
        OrganizationDb db,
        IMapper mapper)
        : ICalculationDeviceRepository
    {
        // 2.	Выбрать все расчетные приборы учета в 2018 году.
        public async Task<IEnumerable<CalculationDeviceResp>> GetAllForYear(int year)
        => mapper.Map<CalculationDevice[], IEnumerable<CalculationDeviceResp>>(
            await db.CalculationDevices
            .Where(t => t.AccountingPeriods
            .Any(i => i.StartDate.Value.Year <= year && i.EndDate.Value.Year >= year))
            .ToArrayAsync());
    }
}
