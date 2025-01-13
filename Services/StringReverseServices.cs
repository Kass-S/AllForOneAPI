using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class StringReverseServices
    {
        public string ReverseString(string reverseStr)
        {
            string reverse = "";
            for(int i = reverseStr.Length - 1 ; i >= 0; i--)
            {
                reverse += reverseStr[i];
            }
            return $"Your input was {reverseStr}, and its reverse is {reverse}";
        }
    }
}