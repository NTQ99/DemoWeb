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
    public class CustomerController : ControllerBase
    {
        string[] customer = { "2", "Nguyễn Văn A", "HN", "0123456789" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return customer;
        }
    }
}
