using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class MadLibServices
    {
        public string MadLib(string noun, string animal, string name, string diffName, string emotion, string action1, string dreamJob, string structure)
        {
            string madLibStr = $"There once was a {noun} that would ride a(n) {animal}, whose name is {name}, in the fields often. {diffName}  would always get {emotion} at the {noun} for it. {diffName} would always tell the {noun} to {action1} instead of riding on {name} all day. The truth is it was the {noun} daydreamed of being a {dreamJob} while riding on {name}. 'Maybe,' the {noun} thought, 'maybe I can be a {dreamJob} and maybe I can work at the {structure} as well!' Mind made up the {noun} rode off into the sunset with {diffName} and {name}. The End";
            return madLibStr;
        }
    }
}