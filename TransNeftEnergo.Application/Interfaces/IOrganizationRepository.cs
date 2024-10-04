using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces
{
    public interface IOrganizationRepository
    {
        IQueryable<OrganizationDto> Organizations();
    }
}
