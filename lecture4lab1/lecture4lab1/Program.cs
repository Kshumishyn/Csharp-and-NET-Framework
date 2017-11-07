// Homework No.? Exercise No.?
// File Name:     lecture4lab1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 18, 2017
//
// Problem Statement: Calculates how far over the Speed Limit someone goes.
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Prompt the user for the Speed Limit and their Velocity
// 2. Calculate whether they were speeding or not and reprimand them appropriately.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4lab1
{
    class Program
    {
        const int FLAT_RATE = 60;
        const int PENALTY_FEE = 250;
        const int SPEED_PENALTY_RATE = 7;

        static void Main(string[] args)
        {
            // Variables
            int speedLimit;
            int velocity;
            int netSpeedViolation;
            int absSpeedViolation;
            int speedTicketFeeDue;

            // Prompts for Speed Limit
            Console.WriteLine("What was the speed limit?");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            // Prompts for Velocity
            Console.WriteLine("And how fast were you going punk?!");
            velocity = Convert.ToInt32(Console.ReadLine());

            // Calculates Difference from Speed Limit
            netSpeedViolation = speedLimit - velocity;

            // Only valid for non-negative numbers
            if (netSpeedViolation >= 0)
            {
                Console.WriteLine("Well done CITIZEN!");
            }
            else
            {
                // Takes Absolute Value for use with $7.00 rate per mile over Speed Limit
                absSpeedViolation = Math.Abs(netSpeedViolation);

                // Returns how much Speed Limit was exceeded
                Console.WriteLine("Okay listen here you punk, you're {0} MPH over the speed limit.", absSpeedViolation);

                // Calculates fee generally
                speedTicketFeeDue = FLAT_RATE + absSpeedViolation * SPEED_PENALTY_RATE;

                // Adds Flat Penalty if 25 over the Speed Limit
                if (absSpeedViolation > 25)
                {
                    speedTicketFeeDue += PENALTY_FEE;
                }

                // Scolds them
                Console.WriteLine("Your fee is {0:c} punk, check yourself before you hurt someone.", speedTicketFeeDue);
            }

            // Stops program from closing
            Console.ReadLine();
        }
    }
}
