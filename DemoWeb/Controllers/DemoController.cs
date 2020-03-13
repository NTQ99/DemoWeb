using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        string[] days = { "Mon", "Tue", "Wed" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return days;
        }
    }
}
