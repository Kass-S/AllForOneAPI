using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AskingQuestionsServices
    {
        public string NameTimeAsk(string name, string time)
        {
            string nameTimeStr = $"Hello {name}! You woke up at {time} today.";
            return nameTimeStr;
        }
    }
}