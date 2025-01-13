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
    public class StringReverseController : ControllerBase
    {
        private readonly StringReverseServices _stringReverseServices;
        public StringReverseController(StringReverseServices stringReverseServices)
        {
            _stringReverseServices = stringReverseServices;
        }

        [HttpGet]
        [Route("ReverseIt/{reverseStr}")]
        public string ReverseString(string reverseStr)
        {
            return _stringReverseServices.ReverseString(reverseStr);
        }
    }
}