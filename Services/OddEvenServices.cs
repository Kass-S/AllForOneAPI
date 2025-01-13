using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class OddEvenServices
    {
        public string OddEven(string oddEvenNum)
        {
            bool validNum = false;
            int convertNum = 0;
            validNum = int.TryParse(oddEvenNum, out convertNum);

            if(validNum == false)
            {
                return "Please enter a valid number.";
            } else
            {
                if(convertNum % 2 == 0)
                {
                    return $"Your number ({convertNum}) is even.";
                }else
                {
                    return $"Your number ({convertNum}) is odd";
                }
            }
        }
    }
}