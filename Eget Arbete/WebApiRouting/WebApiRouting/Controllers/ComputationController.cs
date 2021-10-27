using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiRouting.Controllers
{
    [Route("compute")]
    [ApiController]
    public class ComputationController : ControllerBase
    {
        [HttpGet("message")]
        public string message(string myMessage)
        {
            return $"{myMessage}";
        }

        [HttpGet("upper/{message}")]
        public string Upper(string message)
        {
            return message.ToUpper();
        }

        [HttpGet("concat/{message1}")]
        public string concat(string message1, string message2)
        {
            return message1 + message2;
        }

        [HttpGet("add")]
        public string Add(int int1, int int2)
        {
            int sum = int1 + int2;
            return sum.ToString();
        }

        [HttpGet("add2/{int1}/{int2}")]
        public string Add2(int int1, int int2)
        {
            int sum = int1 + int2;
            return sum.ToString();
        }

        [HttpGet("multi")]
        public string MultiGreeter(int count, string message)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += message;
            }
            return result;
        }
        [HttpGet("multi2/{count}/{message}")]
        public string MultiGreeter2(int count, string message)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += message;
            }
            return result;
        }
        [HttpPost("execute")]
        public int Compute(ComputeUnit compute)
        {
            return compute.Compute();
        }

        [HttpPost("multiexcecute")]
        public int MultiCompute(int count, [FromBody]ComputeUnit computeunit)
        {
            return computeunit.Compute() * count;
        }

        [HttpGet("create-addition")]
        public ComputeUnit CreateAdditionComputation(int value1, int value2)
        {
            ComputeUnit computeUnit = new ComputeUnit();
            computeUnit.Value1 = value1;
            computeUnit.Value2 = value2;
            computeUnit.Mode = "addition";
            return computeUnit;
        }

        [HttpPost("change-mode/{newMode}")]
        public ComputeUnit ChangeMode([FromBody]ComputeUnit computeUnit, string newMode)
        {
            if (newMode == "addition") 
            {
                computeUnit.Mode = "addition";
            }
            else if (newMode == "multiplication")
            {
                computeUnit.Mode = "multiplication";
            } 
            else computeUnit.Mode = "error";
            
            return computeUnit;
        }
    }
}

