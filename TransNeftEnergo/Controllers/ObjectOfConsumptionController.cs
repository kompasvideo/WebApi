using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;

namespace TransNeftEnergo.WebAPI.Controllers
{
    [ApiController]
    public class ObjectOfConsumptionController(
        IObjectOfConsumptionService objectOfConsumptionService)
        : ControllerBase
    {
        /// <summary>
        /// 3.	По указанному объекту потребления выбрать все счетчики 
        /// с закончившимся сроком поверке.
        /// </summary>
        /// <param name="electricityMeasurementPointDto"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/ObjectOfConsumption/AllMetersToEndVerificationDate")]
        public async Task<ActionResult> GetAllMetersToEndVerificationDate([FromBody] ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            var result = await objectOfConsumptionService.GetAllMetersToEndVerificationDate(objectOfConsumptionDto);
            return Ok(result);
        }

        /// <summary>
        /// 4. По указанному объекту потребления выбрать все 
        /// трансформаторы напряжения с закончившимся сроком поверке.
        /// </summary>
        /// <param name="objectOfConsumptionDto"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/ObjectOfConsumption/AllVoltageTransformersToEndVerificationDate")]
        public async Task<ActionResult> GetAllVoltageTransformersToEndVerificationDate([FromBody] ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            var result = await objectOfConsumptionService.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionDto);
            return Ok(result);
        }

        /// <summary>
        /// 5.	По указанному объекту потребления выбрать все 
        /// трансформаторы тока с закончившимся сроком поверке.
        /// </summary>
        /// <param name="objectOfConsumptionDto"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/ObjectOfConsumption/AllCurrentTransformersToEndVerificationDate")]
        public async Task<ActionResult> GetAllCurrentTransformersToEndVerificationDate([FromBody] ObjectOfConsumptionDto objectOfConsumptionDto)
        {
            var result = await objectOfConsumptionService.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionDto);
            return Ok(result);
        }
    }
}
