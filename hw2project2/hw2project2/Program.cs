// Homework No.2 Exercise No.2
// File Name:     hw2project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 6, 2017
//
// Problem Statement: Takes a number in degrees Fahrenheit and converts it to degrees Celsius
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompt for input of a Temperature in Degrees Fahrenheit
// 2. Mathematically calculates value in Degrees Celsius
// 3. Output back to user feedback of what they inputted and what they desired

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            double degreesFahrenheit;
            double degreesCelsius;

            // Info Message
            Console.Write("Please enter the temperature in degrees Fahrenheit:  ");
            degreesFahrenheit = Double.Parse(Console.ReadLine());

            // Converts Fahrenheit to Celsius
            degreesCelsius = 5 * (degreesFahrenheit - 32) / 9;

            // Returns information to user rounded to 1 decimal place
            Console.WriteLine("{0} degrees Fahrenheit is {1} degrees Celsius", Math.Round(degreesFahrenheit, 1), Math.Round(degreesCelsius, 1));

            // Delays Console closing
            Console.ReadLine();
        }
    }
}
