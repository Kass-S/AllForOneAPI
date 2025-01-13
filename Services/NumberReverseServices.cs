using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class NumberReverseServices
    {
        public string ReverseNumber(string numReverseNum)
        {
            bool validNum = false;
            bool reverseLoop = true;
            int intReverse = 0;
            int convertedNum = 0;
            validNum = int.TryParse(numReverseNum, out convertedNum);

            if(validNum == false)
            {
                return "Please enter a valid number.";
            } else
            {
                while(reverseLoop==true)
                {
                    while(convertedNum > 0)
                    {
                        int lastDigit = convertedNum % 10;

                        intReverse = (intReverse * 10) + lastDigit;

                        convertedNum /= 10;
                    }

                    reverseLoop = false;
                } 
                return $"Your input was {numReverseNum}. and its reverse is {intReverse}";
            }            
        }
    }
}