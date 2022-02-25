using System;
using System.Collections.Generic;

namespace GuessingNumber
{
    class GuessingnNumber
    {       static void Main(string[] args)
            {   int guess;
                bool PlayAgain = true;
                Random random = new Random();
                int number;
                int guesses;

                while(PlayAgain)
                {   guess = 0;
                    guesses = 0;
                    number = random.Next(1, 101);
                    while(guess != number)
                    {Console.WriteLine("\nGuess a number between 1 and 100");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nGuess: " + guess);
                    if (guess > number)
                    Console.WriteLine(guess + " is too high !");
                    else 
                    if (guess < number)
                    Console.WriteLine(guess + " is too low !");
                    guesses++ ;

                    }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("-----------------");
                Console.WriteLine("\nYOU WIN !  uwu");
                Console.WriteLine("\nNumber of guesses: " + guesses);
                Console.WriteLine("\nDo you want to play again ? :))) --- Y/N: ");
               string response = Console.ReadLine();
               response = response.ToUpper();
               if( response == "Y" )
               PlayAgain = true;
               else 
               PlayAgain = false;

                }
                Console.WriteLine("\n# Thanks for playing........ See you next time  <^.^>");
                
            }

    }

}