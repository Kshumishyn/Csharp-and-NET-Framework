// Homework No.? Exercise No.?
// File Name:     lecture5lab1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 25, 2017
//
// Problem Statement: Uses RNG for a game
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Generate a random n umber
// 2. Loop through a prompt to guess a number until they get it right
// 3. Give feedback of higher or lower when wrong guesses are made

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture5lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates Random Generator
            Random generator = new Random();

            // Variables
            int numberToGuess = generator.Next(100);
            bool guessedIt = false;
            int numGuessed;
            int numGuesses = 0;

            // Loops until number has been guessed
            while(!guessedIt)
            {
                // Prompts for a number and Evaluates it from string input
                Console.Write("Guess: ");
                numGuessed = Convert.ToInt32(Console.ReadLine());
                
                // If number is guessed
                if (numGuessed == numberToGuess)
                {
                    Console.WriteLine("YOU GUESSED IT!");
                    guessedIt = !guessedIt;
                }

                // If number is not guessed
                else
                {
                    Console.WriteLine("WRONG, TRY AGAIN COOL KID!");

                    // Guessed is more than number
                    if (numGuessed > numberToGuess)
                    {
                        Console.WriteLine("LOWER\n");
                    }
                    // Guessed is less than number
                    else
                    {
                        Console.WriteLine("HIGHER\n");
                    }
                }
                numGuesses++;
            }
            // Feedback on number of guesses
            Console.WriteLine("\n\nTook you {0} tries! How are you so bad!", numGuesses);

            // Stops the Console from Closing
            Console.ReadLine();

        }
    }
}
