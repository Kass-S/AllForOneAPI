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
    public class OddEvenController : ControllerBase
    {
        private readonly OddEvenServices _oddEvenSercices;
        public OddEvenController(OddEvenServices oddEvenServices)
        {
            _oddEvenSercices =  oddEvenServices;
        }

        [HttpGet]
        [Route("OddEvenAnswer/{oddEvenNum}")]
        public string OddEven(string oddEvenNum)
        {
            return _oddEvenSercices.OddEven(oddEvenNum);
        }
    }
}