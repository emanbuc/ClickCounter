using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClickCounter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoServerController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public VideoServerController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get(int code)
        {
            _logger.LogInformation("VideoServerController.Get "+code);
            return "Il servizio è temporaneamente non disponibile";
        }
    }
}
