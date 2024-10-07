using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;

namespace TransNeftEnergo.WebAPI.Controllers
{
    [ApiController]
    public class OrganizationsController(
        IOrganizationService organizationService) 
        : ControllerBase
    {
        [HttpGet("/api/v1/organizations/all")]
        public async Task<ActionResult> GetAllOrganizations()
        {
            var result = await organizationService.GetAll();
            return Ok(result);
        }
    }
}
