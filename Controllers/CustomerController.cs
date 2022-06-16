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
        private static readonly string[] Test = new[]
        {
            "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "Customer6", "Customer7", "Customer8", "Customer9", "Customer10"
        };
        [HttpGet]
        public async Task<IActionResult> GetTest()
        {
            return Ok(Test);
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<string> GetCustomerById(int id)
        {
            return Test[id];
        }
    }
}
