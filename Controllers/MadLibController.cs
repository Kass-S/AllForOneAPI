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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }
        
        [HttpGet]
        [Route("MadLibStory/{noun}/{animal}/{name}/{diffName}/{emotion}/{action1}/{dreamJob}/{structure}")]
        public string MadLib(string noun, string animal, string name, string diffName, string emotion, string action1, string dreamJob, string structure)
        {
            return _madLibServices.MadLib(noun, animal, name, diffName, emotion, action1, dreamJob, structure);
        }
    }
}