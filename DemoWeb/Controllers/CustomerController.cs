using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Get du lieu
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: NTQ (14/03/2020)
        [HttpGet]
        public List<Customer> Get()
        {
            return Customer.Customers;
        }
        /// <summary>
        /// Post du lieu
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: NTQ (14/03/2020)
        [HttpPost]
        public bool Post([FromBody] Customer customer)
        {
            Customer.Customers.Add(customer);
            return true;
        }
    }
}
