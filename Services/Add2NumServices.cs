using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class Add2NumServices
    {
        public string Add(int num1, int num2)
        {
            return $"{num1} added to {num2} equals {num1 + num2}.";
        }
    }
}