using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class Magic8BallServices
    {
        public string EightBall(string question)
        {
            Random rng = new Random();
            int magicRandom = rng.Next(1,9);

            string questionInput = question;

            switch(magicRandom)
            {
                case 1:
                    return $"{questionInput}: Yes";

                case 2:
                    return $"{questionInput}: No";

                case 3:
                    return $"{questionInput}: Maybe";

                case 4:
                    return $"{questionInput}: It is certain";

                case 5:
                    return $"{questionInput}: Don't count on it";

                case 6:
                    return $"{questionInput}: Better not tell you now";

                case 7:
                    return $"{questionInput}: Most likely";

                case 8:
                    return $"{questionInput}: Very unlikely";

                default:
                    return "This is not suppose to happen. How did you get here?";
            }
        }
    }
}