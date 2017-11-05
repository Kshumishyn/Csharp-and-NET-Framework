// Homework No.3 Exercise No.2
// File Name:     hw3project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 15, 2017
//
// Problem Statement: 
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompt for a Valid number cost of an item, error check it
// 2. Mods and Divides cost to figure out quarters and remainder
// 3. Mods and Divides remainder into Dimes, then Nickels
// 4. Returns to the user a formatted output showing their change.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int costItem;
            int numQuarters;
            int numDimes;
            int numNickels;
            int tempRemainder;

            // Prompt for User
            Console.WriteLine("Please Enter price of item to Vend.");
            
            // Runs until valid number is entered given conditions
            do
            {
                Console.WriteLine("Every item must be in 5 cent increments between 25 cents to a dollar.");
                costItem = Convert.ToInt32(Console.ReadLine());
            } while (costItem % 5 != 0 || (costItem < 25 || costItem > 100));

            Console.WriteLine("\nThank you, calculating change from a Dollar...\n");

            // Does Quarters First
            numQuarters = costItem / 25;
            tempRemainder = costItem % 25;

            // Then Dimes
            numDimes = tempRemainder / 10;
            tempRemainder = tempRemainder % 10;

            // Then Nickels
            numNickels = tempRemainder / 5;

            Console.WriteLine("Your change is: \n{0} Quarters,\n{1} Dimes,\nand\n{2} Nickels.", numQuarters, numDimes, numNickels);

            // Keeps Console from closing at the end
            Console.ReadLine();
        }
    }
}
