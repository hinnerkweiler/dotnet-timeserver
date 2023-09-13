using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentTime()
        {
            var currentTime = DateTime.UtcNow;
            var timeObject = new { Time = currentTime };

            return Ok(timeObject);
        }
    }
}