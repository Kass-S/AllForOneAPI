using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class SayHelloServices
    {
        public string SayHello(string name)
        {
            return $"Hi, {name}! It's nice to meet you!";
        }
    }
}