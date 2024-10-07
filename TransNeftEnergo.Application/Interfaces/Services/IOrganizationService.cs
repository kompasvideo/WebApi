using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.Application.Interfaces.Services
{
    public interface IOrganizationService
    {
        Task<IEnumerable<OrganizationDto>> GetAll();
    }
}
