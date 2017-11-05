// Homework No.7 Exercise No.1
// File Name:     hw7project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 23, 2017
//
// Problem Statement: The Odometer Class with instance variables for Miles Driven and Fuel Used

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7project1
{
    class Odometer
    {
        // Constant Variables
        const double DEFAULT_MILES_DRIVEN = 0.0;
        const double DEFAULT_FUEL_USED = 0.0;

        // Instance Variables
        private double milesDriven;
        private double fuelUsed;

        // Default Constructor
        public Odometer()
        {
            SetMilesDriven(DEFAULT_MILES_DRIVEN);
            SetFuelUsed(DEFAULT_FUEL_USED);
        }

        // Full Constructor
        public Odometer(double milesDriven, double fuelUsed)
        {
            SetMilesDriven(milesDriven);
            SetFuelUsed(fuelUsed);
        }

        // Calls Regular Full Constructor, overloads for int parameters
        public Odometer(int milesDriven, int fuelUsed) : 
            this(Convert.ToDouble(milesDriven), Convert.ToDouble(fuelUsed))
        { }

        // Calls Regular Full Constructor, overloads for an int parameter
        public Odometer(int milesDriven, double fuelUsed) :
            this(Convert.ToDouble(milesDriven), fuelUsed)
        { }

        // Calls Regular Full Constructor, overloads for and int parameter
        public Odometer(double milesDriven, int fuelUsed) :
            this(milesDriven, Convert.ToDouble(fuelUsed))
        { }

        // Mutators
        // Sets the Miles Driven
        public void SetMilesDriven(double milesDriven)
        {
            this.milesDriven = milesDriven;
        }

        // Sets the Fuel Used
        public void SetFuelUsed(double fuelUsed)
        {
            this.fuelUsed = fuelUsed;
        }

        // Resets both Miles Driven and Fuel Used
        public void ResetOdometer()
        {
            ResetMilesDriven();
            ResetFuelUsed();
        }

        // Resets Miles Driven
        public void ResetMilesDriven()
        {
            SetMilesDriven(0);
        }

        // Resets Fuel Used
        public void ResetFuelUsed()
        {
            SetFuelUsed(0);
        }

        // Accessors
        // Gets the Miles Driven
        public double GetMilesDriven()
        {
            return milesDriven;
        }

        // Gets the Fuel Used
        public double GetFuelUsed()
        {
            return fuelUsed;
        }

        // Utility Methods
        // Adds to the Miles Driven and Fuel Used
        public void AddMilesAndFuel(double milesDriven, double fuelUsed)
        {
            this.milesDriven += milesDriven;
            this.fuelUsed += fuelUsed;
        }

        // Overloaded addMilesAndFuel
        public void AddMilesAndFuel(int milesDriven, int fuelUsed)
        {
            AddMilesAndFuel(Convert.ToDouble(milesDriven), Convert.ToDouble(fuelUsed));
        }

        // Overloaded addMilesAndFuel
        public void AddMilesAndFuel(int milesDriven, double fuelUsed)
        {
            AddMilesAndFuel(Convert.ToDouble(milesDriven), fuelUsed);
        }

        // Overloaded addMilesAndFuel
        public void AddMilesAndFuel(double milesDriven, int fuelUsed)
        {
            AddMilesAndFuel(milesDriven, Convert.ToDouble(fuelUsed));
        }

        // Returns the Miles Per Gallon given no paramters
        public double FindMilesPerGallon()
        {
            // If the fuelUsed is invalid, simply return the milesDriven
            if (fuelUsed <= 0)
                return milesDriven;

            // Else, fuelUsed is valid
            else
                return milesDriven / fuelUsed;
        }

        // Returns a String representation of the Odometer class
        public override string ToString()
        {
            // Variables
            string resultString;

            // Formats a pretty ToString of Information on the Odometer
            resultString = string.Format("Miles Driven : {0}\nFuel Used : {1}\nMPG : {2}\n",
                                         Math.Round(GetMilesDriven(), 2),
                                         Math.Round(GetFuelUsed(), 2),
                                         Math.Round(FindMilesPerGallon(), 2));

            return resultString;
        }

    }
}
