using Microsoft.AspNetCore.Mvc;

namespace PracticalSixteen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : Controller
    {
        private ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Looging Hello World");
            _logger.LogWarning("Hello World from warning");
            _logger.LogCritical("Hello World from critical");
            return Ok("Hello World");
        }
    }
}
