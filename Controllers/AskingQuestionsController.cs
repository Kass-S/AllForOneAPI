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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices){
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("Asking/{name}/{time}")]
        public string NameTimeAsk(string name, string time)
        {
            return _askingQuestionsServices.NameTimeAsk(name, time);
        }
    }
}