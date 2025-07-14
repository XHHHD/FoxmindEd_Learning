using FoxmindEd_Learning.API.Abstractions.Services;
using FoxmindEd_Learning.API.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FoxmindEd_Learning.API.Controllers
{
    [ApiController]
    [Route("example")]
    public class ExampleEntityController(
        ILogger<ExampleEntityController> logger,
        IExampleEntityService exampleEntityService) : ControllerBase
    {
        private readonly ILogger<ExampleEntityController> _logger = logger;
        private readonly IExampleEntityService _exampleEntityService = exampleEntityService;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ExampleEntity entity)
        {
            _logger.LogInformation($"{DateTime.UtcNow.ToShortTimeString()}Post example entity");
            await _exampleEntityService.PostAsync(entity);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation($"{DateTime.UtcNow.ToShortTimeString()}Get example entities");
            var entities = await _exampleEntityService.GetAllAsync();
            return Ok(entities);
        }
    }
}
