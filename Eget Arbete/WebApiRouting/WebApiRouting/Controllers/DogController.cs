using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiRouting.Controllers
{
    [Route("dog")]
    [ApiController]
    public class DogController : ControllerBase
    {
        [HttpPost("pet")]
        public IActionResult Pet([FromBody]Dog dog)
        {
            if(dog.HappinessLevel == "Happy")
            {
            dog.HappinessLevel = "Very Happy";
            }
            else
            {
                dog.HappinessLevel = "Happy";
            }

            return Ok(dog);
        }

        [HttpPost("kick")]
        public IActionResult Kick([FromBody]Dog dog)
        {
            return BadRequest(dog);
        }

        [HttpPost("find-sock")]
        public IActionResult FindSock([FromBody] Dog dog)
        {
            if (dog.HappinessLevel == "very happy")
            {
                return BadRequest(dog);
            }
            else
            {
                return Ok("Sock Found");
            }
        }
    }
}
