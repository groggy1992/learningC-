using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Api.Controllers
{
    [Route("test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public String ReturnHelloWorld()
        {
            return "HellowWorld";
        }
    }
}
