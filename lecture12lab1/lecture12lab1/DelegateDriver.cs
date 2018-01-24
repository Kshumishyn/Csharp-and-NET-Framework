// Homework No.? Exercise No.?
// File Name:     DelegateDriver.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 20, 2017
//
// Problem Statement: Tries out Optional Parameters and Delegates
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Make silly methods
// 2. Run them, then change delegate value
// 3. Prove important life lesson
// 4. ????
// 5. INVEST
// 6. PROFIT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture12lab1
{
    class DelegateDriver
    {
        // Random Number generator
        private static Random rand = new Random();

        // Delegate
        public delegate bool Del(int num1, int num2);

        static void Main(string[] args)
        {
            int numLoops = 5;
            Del spendMoneyHow = Gamble;

            for (int i = 0; i < numLoops; i++)
                Console.WriteLine("I'm great at Gambling! : " + spendMoneyHow(1, 2));

            Console.WriteLine("");

            spendMoneyHow = Invest;

            for (int i = 0; i < numLoops; i++)
                Console.WriteLine("I'm great at Investing! : " + spendMoneyHow(1, 2));

            Console.WriteLine("\nAs can be seen, investing is always better!");

            // Waits to close console
            Console.ReadLine();
        }

        public static bool Gamble(int bet, int possible = 6)
        {
            int correctValue = rand.Next(1, possible + 1);

            if (bet == correctValue)
                return true;
            else
                return false;
        }

        public static bool Invest(int amountInvested, int yearsInvested = 1)
        {
            return true;
        }
    }
}
