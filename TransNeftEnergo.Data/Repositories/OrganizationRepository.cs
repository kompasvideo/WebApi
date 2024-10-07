using AutoMapper;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class OrganizationRepository
        (OrganizationDb _organizationDb,
        IMapper _mapper)
        : IOrganizationRepository
    {
        public async Task<IQueryable<OrganizationDto>> GetAll()
        {
            return _organizationDb.Organizations.Select(t => _mapper.Map<OrganizationDto>(t));
        }
    }
}
