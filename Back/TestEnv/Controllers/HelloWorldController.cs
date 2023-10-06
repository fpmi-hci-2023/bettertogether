using Microsoft.AspNetCore.Mvc;

namespace TestEnv.Controllers
{
    [ApiController]
    [Route("hello-world")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHelloWorld()
        {
            return this.Ok("Hello world!");
        }
    }
}