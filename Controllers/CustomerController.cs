using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static  List<string> Customer = new List<string>
        {
            "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "Customer6", "Customer7", "Customer8", "Customer9", "Customer10"
        };
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            return Ok(Customer);
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<string> GetCustomerById(int id)
        {
            return Customer[id];
        }
        [HttpPost]
        [Route("api/[controller]/Create")]
        public async Task<IActionResult> CreateCustomer()
        {
            string newCustomer = "Customer679";
            Customer.Add(newCustomer);
            return Ok(Customer);
        }
    }
}
