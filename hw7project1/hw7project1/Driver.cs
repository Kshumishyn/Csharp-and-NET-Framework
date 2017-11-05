// Homework No.7 Exercise No.1
// File Name:     hw7project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 23, 2017
//
// Problem Statement: Tests the Odometer Class
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Tests the Basic Methods for the Odometer Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7project1
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Declaration
            Odometer defaultOdometer;
            Odometer customOdometer;

            // Initialization
            defaultOdometer = new Odometer();
            customOdometer = new Odometer(200, 16.5);

            // Prints the Initial Information
            Console.WriteLine("Default Odometer:\n" + defaultOdometer.ToString());
            Console.WriteLine("Custom Odometer:\n" + customOdometer.ToString());

            // Tests out all the Reset Methods for Odometer
            customOdometer.ResetOdometer();
            Console.WriteLine("Reset Custom Odometer:\n" + customOdometer.ToString());

            // Tests out all the Addition Methods for Odometer
            customOdometer.AddMilesAndFuel(140, 7);
            Console.WriteLine("Added to Custom Odometer:\n" + customOdometer.ToString());

            // Prevents Program from closing
            Console.ReadLine();
        }
    }
}
