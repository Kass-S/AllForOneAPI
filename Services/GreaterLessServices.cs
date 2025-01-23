using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class GreaterLessServices
    {
        public string GreaterLessThan(string num1, string num2){
            string greaterLessStr = "";

            bool validNum1 = false;
            bool validNum2 = false;
            int convertedNum1 = 0;
            int convertedNum2 = 0;
            validNum1 = int.TryParse(num1, out convertedNum1);
            validNum2 = int.TryParse(num2, out convertedNum2);

            if(validNum1 == false || validNum2 == false)
            {
                return "Please enter a valid number.";
            }else if(convertedNum1 > convertedNum2)
            {
                greaterLessStr = $"{convertedNum1} is greater than {convertedNum2}. {convertedNum2} is less than {convertedNum1}.";
            }else if(convertedNum1< convertedNum2)
            {
                greaterLessStr = $"{convertedNum2} is greater than {convertedNum1}. {convertedNum1} is less than {convertedNum2}.";
            }else if(convertedNum1 == convertedNum2)
            {
                greaterLessStr = $"{convertedNum1} and {convertedNum2} are equal.";
            }

            return greaterLessStr;
        }
    }
}