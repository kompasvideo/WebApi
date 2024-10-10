using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class CalculationDeviceRepository(
        OrganizationDb _Db,
        IMapper mapper)
        : ICalculationDeviceRepository
    {
        // 2.	Выбрать все расчетные приборы учета в 2018 году.
        public async Task<IEnumerable<CalculationDeviceDto>> GetAllForYear(int year)
        {
            var result = await _Db.CalculationDevices.Where(t => t.AccountingPeriods.Any(
                i => i.StartDate.Year <= year && i.EndDate.Year >= year)).ToListAsync();            
            return mapper.Map<IEnumerable<CalculationDeviceDto>>(result); 
        }
    }
}
