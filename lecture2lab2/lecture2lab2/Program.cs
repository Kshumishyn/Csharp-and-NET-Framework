// Homework No.# Exercise No.#
// File Name:     lecture2lab2.cs
// @author:       Kostyantyn Shumishyn
// Date:          August 28, 2017
//
// Problem Statement: Prompt for an Input of Total number of Coupons, and find out how
// many Candy Bars and Gumballs you can get while favoring gumballs.
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompt for Total Number of Coupons
// 2. Divide Total by Constant cost of Candy Bars to get # of Candy Bars
// 3. Mod Total by Constant cost of Candy Bars then Divide by Constant Cost of
//    of Gumballs to get # of Gumballs
// 4. Print out the number of each for the user


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2lab2
{
    class Program
    {
        // Constants
        public const int CANDYBAR_COST = 10;
        public const int GUMBALL_COST  = 3;

        static void Main(string[] args)
        {
            // Declarations
            int numCouponsWon;
            int numCandyBarsPossible;
            int numGumballsPossible;

            // Prompts for Ticket Amount won
            Console.WriteLine("Hello, how many tickets did you win?");
            numCouponsWon = Int32.Parse(Console.ReadLine());

            // Finds out how many Candy Bars can be bought first
            numCandyBarsPossible = numCouponsWon / CANDYBAR_COST;

            // Takes remaining amount after Candy bars and uses that to find Gumballs
            numGumballsPossible = (numCouponsWon % CANDYBAR_COST) / GUMBALL_COST;

            // Prints Information
            Console.WriteLine("You can get " + numCandyBarsPossible + " Candy Bar(s) and " + numGumballsPossible + " gumball(s)! YUM!");

            // Delays Program Close, wait for Enter input
            Console.ReadLine();
        }
    }
}
