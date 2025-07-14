using Microsoft.AspNetCore.Mvc;

namespace FoxmindEd_Learning.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(
        ILogger<WeatherForecastController> logger) : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger = logger;

        [HttpGet("GetWeatherForecast")]
        public IActionResult Get()
        {
            _logger.LogInformation("GetWeatherForecast called");
            return Ok();
        }
    }
}
