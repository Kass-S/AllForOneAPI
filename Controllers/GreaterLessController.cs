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
    public class GreaterLessController : ControllerBase
    {
        private readonly GreaterLessServices _greaterLessServives;
        public GreaterLessController(GreaterLessServices greaterLessServices){
            _greaterLessServives = greaterLessServices;
        }

        [HttpGet]
        [Route("GreaterLessThan/{num1}/{num2}")]
        public string GreaterLessThan(string num1, string num2){
            return _greaterLessServives.GreaterLessThan(num1, num2);
        }
    }
}