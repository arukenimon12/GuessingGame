using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int RandNum = rand.Next(1,100);

        back:
            Console.Write("Guess the number: ");
            int guess;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                goto back;
            }

            void Retry()
            {
                Console.Write("Retry?(Y/N): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "y")
                {
                    Main(null);
                }
                else if (choice.ToLower() == "n")
                {
                    Console.WriteLine("Game finished.");
                }
                else
                    Retry();
            }

            if (guess > RandNum)
            {
                Console.WriteLine("Too higher");
                goto back;
            }
            if (guess < RandNum)
            {
                Console.WriteLine("Too lower");
                goto back;
            }
            if(guess == RandNum)
            {
                Console.WriteLine("You are correct.");

                Retry();

            }
            Console.ReadKey();

        }
    }
}
