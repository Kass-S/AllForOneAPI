using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumController : ControllerBase
    {
        private readonly Add2NumServices _add2NumServices;
        public Add2NumController(Add2NumServices add2NumServices){
            _add2NumServices = add2NumServices;
        }

        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string Add(int num1, int num2)
        {
            return _add2NumServices.Add(num1, num2);
        }
    }
}