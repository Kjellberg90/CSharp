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
    public class ExerciseController : ControllerBase
    {
        [HttpGet("Ping")]
        public string Ping()
        {
            return "Pong";
        }

        [HttpGet("Concat")]
        public string Concat(string string1, string string2)
        {
            return string1 + string2;
        }
    }
}
