using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Logic.Services
{
    public class OrganizationService(
        IOrganizationRepository organizationRepository)
        : IOrganizationService
    {
        public async Task<IEnumerable<OrganizationDto>> GetAll()
        {
            return await organizationRepository.GetAll();
        }
    }
}
