using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
           string secret = "turtle";
           string guess = "";
           int guessCount = 0;
           int guessLimit = 3;
           bool noGuess = false;

           while(guess != secret && !noGuess) 
           {
               if(guessCount < guessLimit)
               {
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
               }
               else
               {
                    noGuess = true;
               }
           }
           if(noGuess)
           {
               Console.Write("WRONG!");
           }
           else
           {
               Console.Write("Correct!");
           }
           
           Console.ReadLine();
        }
    }
}
