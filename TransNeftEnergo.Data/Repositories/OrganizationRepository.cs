using AutoMapper;
using TransNeftEnergo.Application.Interfaces;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class OrganizationRepository
        (OrganizationDb _organizationDb,
        IMapper _mapper)
        : IOrganizationRepository
    {
        public IQueryable<OrganizationDto> Organizations()
        {
            return _organizationDb.Organizations.Select(t => _mapper.Map<OrganizationDto>(t));
        }
    }
}
