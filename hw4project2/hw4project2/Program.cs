// Homework No.4 Exercise No.2
// File Name:     hw4project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 25, 2017
//
// Problem Statement: Prints out Statistics for a number of coin tosses
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Asks how many Coin flips the user wishes to do
// 2. Loops the specified number of times
// 3. Error checks for an input beginning with "h" or "t"
// 4. If H increments the number of heads, likewise for T
// 5. Calculates what the percentage of heads and tails are, for each out of the total
// 6. Outputs to the user the number of heads and tails as well as the percentage of each one

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numCoinFlips;
            int numHeads;
            int numTails;

            double percentHeads;
            double percentTails;

            string toss;
            string firstLetter;

            bool invalidLetter;

            // Prompts for number of tosses
            Console.WriteLine("How many coin tosses would you like to do?");
            numCoinFlips = Convert.ToInt32(Console.ReadLine());

            // Gives Instructions
            Console.WriteLine("For each coin toss enter either ‘h’ for heads or ‘t’ for tails.");

            // Initializes to be used
            numHeads = 0;
            numTails = 0;

            // Flips the number of coins specified
            for (int index = 0; index < numCoinFlips; index++)
            {
                // Error checks to make sure you are at least inputting something that starts with h or t
                do
                {
                    // Prints Toss #
                    Console.WriteLine("Toss #{0}:", (index + 1));

                    // Looks at the first letter of any string you enter
                    toss = Console.ReadLine();
                    firstLetter = toss.ElementAt(0) + "";
                    firstLetter = firstLetter.ToLower();

                    // Gives Feedback
                    invalidLetter = (firstLetter != "t" && firstLetter != "h");

                    // Gives Input Feedback
                    if (invalidLetter)
                    {
                        Console.WriteLine("\nPlease enter something that starts with h or t at least.");
                    }
                }
                while (firstLetter != "t" && firstLetter != "h") ;

                // Formatting Linebreak
                Console.WriteLine();

                // Checks which outcome it was, and increments that counter
                if (firstLetter == "t")
                {
                    numTails++;
                }
                // Because it can be said with confidence you left the do while loop, else can be assumed to be "h"
                else
                {
                    numHeads++;
                }
            }

            // Converts to Decimals
            percentHeads = (double)numHeads / numCoinFlips;
            percentTails = (double)numTails / numCoinFlips;
            
            // Outputs Feedback
            Console.WriteLine("Number of Heads is {0}!\nNumber Of Tails is {1}!", numHeads, numTails);
            Console.WriteLine("Percentage Heads is {0:P2}!\nPercentage Tails is {1:P2}!", percentHeads, percentTails);

            // Waits before closing the program
            Console.ReadLine();
        }
    }
}
