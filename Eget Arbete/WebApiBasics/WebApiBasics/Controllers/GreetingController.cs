using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet("Ping")]
        public string Ping()
        {
            return "Pong";
        }

        [HttpGet("Hello")]
        public string Hello(string name)
        {
            return $"Hello {name}";
        }
    }
}
