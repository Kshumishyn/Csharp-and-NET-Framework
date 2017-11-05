// Homework No.5 Exercise No.1
// File Name:     hw5project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 2, 2017
//
// Problem Statement: Prompts for size of triangle (from 1 to 50), where the size is the height, and prints it out
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompts the user for height of triangle
// 2. Uses an incrementor to get the increasing number slope of triangle with for loops
// 3. Uses an else condition for the center-most part of triangle
// 4. Uses same incrementor subtracting from double the height to create pseudo-decrementor
// 5. Uses decrementor to get the decreasing number slope of triangle again using a for loop
// 6. Prints all of those using loop statements, which continue until the end of the second slope is reached

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5project1
{
    class Program
    {
        // COMMENT: Let's be honest, probably not the prettiest solution memory-wise but what can yah do

        static void Main(string[] args)
        {
            // Variables
            int heightOfTriangle;
            int firstHeight;
            int secondHeight;
            int twiceHeight;

            // Prompts for number of tosses
            Console.WriteLine("How tall is the triangle? Please choose a height between 1 and 50 (inclusive)");
            heightOfTriangle = Convert.ToInt32(Console.ReadLine());

            // Gives Instructions
            Console.WriteLine("\nYour Triangle;\n");

            // Initialize Variables if necessary
            firstHeight = 1;
            secondHeight = heightOfTriangle;
            twiceHeight = 2 * heightOfTriangle;

            // While the other side hasn't completed
            while (secondHeight != 0)
            {
                // Prints first slope
                if (firstHeight < heightOfTriangle)
                {
                    for (int i = 0; i < firstHeight; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                // Prints second Slope
                else if (firstHeight > heightOfTriangle)
                {
                    // Second height is a decreasing first height
                    secondHeight = twiceHeight - firstHeight;

                    for (int i = 0; i < secondHeight; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                // Prints Midsection
                else
                {
                    for (int i = 0; i < heightOfTriangle; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // Increments
                firstHeight++;
            }

            // Waits before closing the program
            Console.ReadLine();
        }
    }
}
