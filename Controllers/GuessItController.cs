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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItService;

        public GuessItController(GuessItServices guessItService){
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("Easy/{easyUserGuess}")]

        public string GuessItEasy(string easyUserGuess)
        {
            return _guessItService.GuessItEasy(easyUserGuess);
        }

        [HttpGet]
        [Route("Medium/{mediumUserGuess}")]

        public string GuessItMedium(string mediumUserGuess)
        {
            return _guessItService.GuessItMedium(mediumUserGuess);
        }

        [HttpGet]
        [Route("Hard/{hardUserGuess}")]

        public string GuessItHard(string hardUserGuess)
        {
            return _guessItService.GuessItHard(hardUserGuess);
        }
    }
}