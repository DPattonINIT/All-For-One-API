using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.Services
{
    public class GuessItService
    {
         public string CheckGuess(int guess, int min, int max)
        {

            var random = new Random();
            int target = random.Next(min, max + 1);


            if (guess == target)
            {
                return "Correct!";
            }
            else if (guess < target)
            {
                return "Too low!";
            }
            else
            {
                return "Too high!";
            }
        }
    }
}