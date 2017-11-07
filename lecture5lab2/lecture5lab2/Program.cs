// Homework No.? Exercise No.?
// File Name:     lecture5lab2.cs
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
// 7. Now stores values into Arrays and is able to print the arrays back... for some reason

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
            int binaryFlip;
            int numCoinFlips;
            int numHeads;
            int numTails;

            double percentHeads;
            double percentTails;
        
            Random generator = new Random();

            // Prompts for number of tosses
            Console.WriteLine("How many coin tosses would you like to do?");
            numCoinFlips = Convert.ToInt32(Console.ReadLine());

            // Creates Arrays
            int[] listHeads = new int[numCoinFlips];
            int[] listTails = new int[numCoinFlips];

            // Gives Instructions
            Console.WriteLine("For each coin toss enter either ‘h’ for heads or ‘t’ for tails.");

            // Initializes to be used
            numHeads = 0;
            numTails = 0;

            // Flips the number of coins specified
            for (int index = 0; index < numCoinFlips; index++)
            {
                // Prints Toss #
                Console.Write("Toss #{0}:", (index + 1));
                binaryFlip = generator.Next(1, 3);
                Console.WriteLine(binaryFlip);

                if (binaryFlip == 1)
                {
                    listHeads[numHeads++] = binaryFlip;
                }
                else if (binaryFlip == 2)
                {
                    listTails[numTails++] = binaryFlip;
                }
            }

            // Converts to Decimals
            percentHeads = (double)numHeads / numCoinFlips;
            percentTails = (double)numTails / numCoinFlips;

            // Outputs Feedback
            Console.WriteLine("Number of Heads is {0}!\nNumber Of Tails is {1}!", numHeads, numTails);
            Console.WriteLine("Percentage Heads is {0:P2}!\nPercentage Tails is {1:P2}!", percentHeads, percentTails);


            Console.WriteLine("\n\nList Heads : ");
            foreach (int num in listHeads)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nList Tails : ");
            foreach (int num in listTails)
            {
                Console.Write(num + " ");
            }

            // Waits before closing the program
            Console.ReadLine();
        }
    }
}
