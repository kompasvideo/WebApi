using System.Net;
using System.Text.Json;
using TransNeftEnergo.Core.Exceptions;

namespace TransNeftEnergo.WebAPI.Middleware
{
    public class ExceptionsMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                try
                {
                    await _next.Invoke(context);
                }
                catch (Exception ex)
                {
                    var result = ExceptionMessageAsync(context, ex);
                    await context.Response.WriteAsync(result);
                }
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 520;
            }
        }

        private string ExceptionMessageAsync(HttpContext context, Exception exception)
        {
            int statusCode = (int)HttpStatusCode.InternalServerError;
            switch (exception)
            {
                case ElectricityMeasurementPointException:
                case CalculationDeviceException:
                case ObjectOfConsumptionException:
                    statusCode = 400;
                    break;
            }

            var result = JsonSerializer.Serialize(new { error = exception.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;
            return result;
        }
    }
}
