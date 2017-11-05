// Homework No.5 Exercise No.3
// File Name:     hw5project3.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 2, 2017
//
// Problem Statement: Reversing an Array
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Create an Array of Integers
// 2. Print out Original, for reference
// 3. By Choice, decide instruction is to Overwrite original with its reverse self
// 4. Store reverse of array into a temporary Array
// 5. Copy from temporary into original
// 6. Print Original Array again to see the change

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5project3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int[] lostNumbers = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] tempArray = new int[lostNumbers.Length];
            int arrayLength;

            // Prints original array
            Console.WriteLine("Original Array; ");
            foreach (int number in lostNumbers)
            {
                Console.Write("{0} ", number);
            }

            // Length of Original Array
            arrayLength = lostNumbers.Length;

            // Creates Reverse copy of original array
            for (int i = 0; i < arrayLength; i++)
            {
                tempArray[arrayLength - 1 - i] = lostNumbers[i];
            }

            // Overwrites original array with reversed one
            for (int i = 0; i < arrayLength; i++)
            {
                lostNumbers[i] = tempArray[i];
            }

            // Prints Reverse of Original Array
            Console.WriteLine("\nReversed Array;");
            foreach (int number in lostNumbers)
            {
                Console.Write("{0} ", number);
            }

            // Waits to close Program
            Console.ReadLine();
        }
    }
}
