using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;

namespace TransNeftEnergo.WebAPI.Controllers
{
    [ApiController]
    public class CalculationDeviceController(
        ICalculationDeviceService calculationDeviceService)
        : ControllerBase
    {
        /// <summary>
        /// 2.	Выбрать все расчетные приборы учета в 2018 году.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/v1/CalculationDevice")]
        public async Task<ActionResult> GetAllCalculationDeviceForYear()
        {
            var result = await calculationDeviceService.GetAllForYear(2018);
            return Ok(result);
        }
    }
}
