// Homework No.7 Exercise No.2
// File Name:     hw7project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 23, 2017
//
// Problem Statement: Tests the Temperature Class
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Tests the Basic Methods for the Temperature Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7project2
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Declaration
            Temperature defaultTemperature;
            Temperature customTemperature;
            Temperature partialTemperatureA;
            Temperature partialTemperatureB;

            // Initialization
            defaultTemperature = new Temperature();
            customTemperature = new Temperature(104, 'F'); // Should be 40 Celsius equivalent, 104 F
            partialTemperatureA = new Temperature(40);     // should be 104 Fahrenheit equivalent, 40 C
            partialTemperatureB = new Temperature('f');    // should be 0 Fahrenheit

            // Prints the Initial Information
            Console.WriteLine("---- Testing Constructors ----");
            Console.WriteLine("Default Temperature:\n" + defaultTemperature.ToString());
            Console.WriteLine("Custom Temperature:\n" + customTemperature.ToString());
            Console.WriteLine("Partial Temperature A should be 40 C:\n" + partialTemperatureA.ToString());
            Console.WriteLine("Partial Temperature B should be 0 F:\n" + partialTemperatureB.ToString());

            // Tests out the Getters and Setters and Equals
            Console.WriteLine("\n\n---- Testing Methods ----");

            // Tests Get Scale Method
            Console.WriteLine("Partial Temp B should be Fahrenheit: " + partialTemperatureB.GetScale());

            // Tests Get Temperature Celsius/Fahrenheit and Equals Method
            Console.WriteLine("\nFirst temperature is " + customTemperature.GetTemperatureFahrenheit() +
                           " F and Second temperature in Fahrenheit is " + partialTemperatureA.GetTemperatureFahrenheit() +
                           " F\nAre they equal? (True/False): " + customTemperature.Equals(partialTemperatureA) + "\n");

            // Tests invalid Set Scale Method
            Console.WriteLine("Assigning Invalid Scale should prompt for Valid one: ");
            partialTemperatureB.SetScale('x');

            // Tests Set Temperature Method and Overloading Constructors
            partialTemperatureB.SetTemperature(17);
            partialTemperatureB.SetScale('F');
            Console.WriteLine("\nTemperature should be 17 F is it?: " + partialTemperatureB.Equals(new Temperature(17, "F")));

            // Tests Equals can return false
            Console.WriteLine("\nTemperature shouldn't be 81 C is it?: " + partialTemperatureB.Equals(new Temperature(81, "C")));

            // Prevents Program from closing
            Console.ReadLine();
        }
    }
}
