using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class Add2NumServices
    {
        public string Add(string num1, string num2)
        { 
            bool validNum1 = false;
            bool validNum2 = false;
            int convertedNum1 = 0;
            int convertedNum2 = 0;
            validNum1 = int.TryParse(num1, out convertedNum1);
            validNum2 = int.TryParse(num2, out convertedNum2);

            if(validNum1 == false)
            {
                return "Please enter a valid number.";
            } else
            {
                return $"{convertedNum1} added to {convertedNum2} equals {convertedNum1 + convertedNum2}.";
            }
            
        }
    }
}