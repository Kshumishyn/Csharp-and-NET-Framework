// Homework No.5 Exercise No.2
// File Name:     hw5project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 2, 2017
//
// Problem Statement: Copying an Array
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Create an Array of Integers
// 2. Use Original Array's length to create another array of same length
// 3. Using for loop, copy each index of original into corresponding copy index
// 4. Print Original and Copy to compare visually

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int[] lostNumbers = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] copyArray = new int[lostNumbers.Length];

            // Copies contents of one array to another, integers only really
            for (int i = 0; i < lostNumbers.Length; i++)
            {
                copyArray[i] = lostNumbers[i];
            }

            // Prints original array
            Console.WriteLine("Original Array; ");
            foreach (int number in lostNumbers)
            {
                Console.Write("{0} ", number);
            }

            // Prints new Copy of Original Array
            Console.WriteLine("\nCopied Array;");
            foreach (int number in copyArray)
            {
                Console.Write("{0} ", number);
            }

            // Waits to close Program
            Console.ReadLine();
        }
    }
}
