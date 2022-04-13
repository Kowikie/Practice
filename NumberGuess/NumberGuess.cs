using System;

namespace CodePractice
{
    public class NumberGuess
    {
        static void Main(string[] args)
        {
            int answer = 27;
            int guess = 0;
            int count = 0;
            int limit = 3;
            bool noGuess = false;

            Console.WriteLine("Try to guess my age in 3 tries.");
            do
            {
                if (count < limit && guess != answer)
                {
                    guess = Guess(ref count);
                }
                else if (count >= limit)
                {
                    noGuess = true;
                }
            } while (guess != answer && !noGuess);
            if (noGuess)
            {
                Console.WriteLine("Sorry. Try Again.");
            }
            else
            {
                Console.WriteLine("You got the right age!");
            }
            
            Console.ReadLine();
        }

        private static int Guess(ref int count)
        {
            int guess;
            int answer = 27;
            Console.Write("Enter a Number from 1 to 100:");
            guess = Convert.ToInt32(Console.ReadLine());
            count++;
            if (guess > 100 || guess < 1)
            {
                Console.WriteLine("Outside the Range");
            }
            if (guess > answer)
            {
                Console.WriteLine("Too high.");
            }
            if (guess < answer)
            {
                Console.WriteLine("Too low.");
            }

            return guess;
        }
    }
}
