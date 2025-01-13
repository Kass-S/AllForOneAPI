using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(string easyUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(easyUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and ten.";
            } else
            {
                Random rng = new Random();
                int easy = rng.Next(1,11);

                if(convertedNum > 10 || convertedNum < 1)
                {
                    return "Whoa! That number is not between one and ten!";
                }else if(convertedNum == easy)
                {
                    return $"Thats correct! You guessed it!\nThe number was {easy}!";
                }else if(convertedNum > easy)
                { 
                    return $"Woops! Looks like you guessed higher then you should have!\nThe number was {easy}.";
                }else
                {  
                    return $"Oh dear! Looks like you guessed lower then you should have!\nThe number was {easy}.";
                }
            }
        }

        public string GuessItMedium(string mediumUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(mediumUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and fifty.";
            } else
            {
                Random rng = new Random();
                int medium = rng.Next(1,51);

                if(convertedNum > 50 || convertedNum < 1)
                {
                    return "Whoa! That number is not between one and fifty!";
                }else if(convertedNum == medium)
                {
                    return $"Thats correct! You guessed it!\nThe number was {medium}!";
                }else if(convertedNum > medium)
                { 
                    return $"Woops! Looks like you guessed higher then you should have!\nThe number was {medium}.";
                }else
                {  
                    return $"Oh dear! Looks like you guessed lower then you should have!\nThe number was {medium}.";
                }
            }
        }

        public string GuessItHard(string hardUserGuess){
            bool validNum = false;
            int convertedNum = 0;
            validNum = int.TryParse(hardUserGuess, out convertedNum);
        
            if(validNum == false)
            {
                return "Please enter a valid number between one and one-hundred.";
            } else
            {
                Random rng = new Random();
                int hard = rng.Next(1,101);

                if(convertedNum > 100 || convertedNum < 1)
                {
                    return "Whoa! That number is not between one and one-hundred!";
                }else if(convertedNum == hard)
                {
                    return $"Thats correct! You guessed it!\nThe number was {hard}!";
                }else if(convertedNum > hard)
                { 
                    return $"Woops! Looks like you guessed higher then you should have.\nThe number was {hard}.";
                }else
                {  
                    return $"Oh dear! Looks like you guessed lower then you should have!\nThe number was {hard}.";
                }
            }
        }
    }
}