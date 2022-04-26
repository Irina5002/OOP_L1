using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab_1._1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        NumberGenerator Number;

        public WeatherForecastController (NumberGenerator a)
        {
            Number = a;
        }

        [HttpGet]
        public int Generate()
        {
            return (Number.Generate());
        }
    }
}
