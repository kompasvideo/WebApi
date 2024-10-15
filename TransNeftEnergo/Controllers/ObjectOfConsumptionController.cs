using Microsoft.AspNetCore.Mvc;
using TransNeftEnergo.Application.Interfaces.Services;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;

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
        [HttpPost("/api/v1/ObjectOfConsumption/AllMetersToEndVerificationDate")]    // ПС 110/10 Весна
        public async Task<ActionResult> GetAllMetersToEndVerificationDate([FromBody] ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var result = await objectOfConsumptionService.GetAllMetersToEndVerificationDate(objectOfConsumptionReq);
            return Ok(result);
        }

        /// <summary>
        /// 4. По указанному объекту потребления выбрать все 
        /// трансформаторы напряжения с закончившимся сроком поверке.
        /// </summary>
        /// <param name="objectOfConsumptionReq"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/ObjectOfConsumption/AllVoltageTransformersToEndVerificationDate")]    // ПС 110/10 Весна
        public async Task<ActionResult> GetAllVoltageTransformersToEndVerificationDate([FromBody] ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var result = await objectOfConsumptionService.GetAllVoltageTransformersToEndVerificationDate(objectOfConsumptionReq);
            return Ok(result);
        }

        /// <summary>
        /// 5.	По указанному объекту потребления выбрать все 
        /// трансформаторы тока с закончившимся сроком поверке.
        /// </summary>
        /// <param name="objectOfConsumptionReq"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/ObjectOfConsumption/AllCurrentTransformersToEndVerificationDate")]    // ПС 110/10 Весна
        public async Task<ActionResult> GetAllCurrentTransformersToEndVerificationDate([FromBody] ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var result = await objectOfConsumptionService.GetAllCurrentTransformersToEndVerificationDate(objectOfConsumptionReq);
            return Ok(result);
        }
    }
}
