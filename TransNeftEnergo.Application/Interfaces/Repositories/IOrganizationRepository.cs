using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Repositories
{
    public interface IOrganizationRepository
    {
        Task<IQueryable<OrganizationDto>> GetAll();
    }
}
