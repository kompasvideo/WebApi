using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.WebAPI.Controllers
{
    [ApiController]
    public class ElectricityMeasurementPointController(
        IElectricityMeasurementPointService electricityMeasurementPointService)
        : ControllerBase
    {
        /// <summary>
        /// 1.	Добавить новую точку измерения с указанием счетчика, 
        /// трансформатора тока и трансформатора напряжения.
        /// </summary>
        /// <param name="electricityMeasurementPointDto"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/ElectricityMeasurementPoint")]
        public async Task<ActionResult> Add([FromBody] ElectricityMeasurementPointDto electricityMeasurementPointDto)
        {
            var result = await electricityMeasurementPointService.Add(electricityMeasurementPointDto);
            return Ok(result);
        }
    }
}
