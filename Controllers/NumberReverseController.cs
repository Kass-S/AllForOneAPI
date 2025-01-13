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
    public class NumberReverseController : ControllerBase
    {
        private readonly NumberReverseServices _numberReverseSercices;
        public NumberReverseController(NumberReverseServices numberReverseServices)
        {
            _numberReverseSercices =  numberReverseServices;
        }

        [HttpGet]
        [Route("NumberReverseIt/{numReverseNum}")]
        public string ReverseNumber(string numReverseNum)
        {
            return _numberReverseSercices.ReverseNumber(numReverseNum);
        }
    }
}