using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Requests;

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
        /// <param name="electricityMeasurementPointReq"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/ElectricityMeasurementPoint")]
        public async Task<ActionResult> Add([FromBody] ElectricityMeasurementPointReq electricityMeasurementPointReq)
        {
            var result = await electricityMeasurementPointService.Add(electricityMeasurementPointReq);
            return Ok(result);
        }
    }
}
