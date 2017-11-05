// Homework No.7 Exercise No.2
// File Name:     hw7project2.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 23, 2017
//
// Problem Statement: The Temperature Class with instance variables for Temperature and Scale

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7project2
{
    class Temperature
    {
        // Constant Variables
        const double DEFAULT_TEMPERATURE = 0.0;
        const char DEFAULT_SCALE = 'C';

        // Instance Variables
        private double temperature;
        private char scale;

        // Default Constructor
        public Temperature()
        {
            SetTemperature(DEFAULT_TEMPERATURE);
            SetScale(DEFAULT_SCALE);
        }

        // Full Constructor
        public Temperature(double temperature, char scale)
        {
            SetTemperature(temperature);
            SetScale(scale);
        }

        // Partial Constructor Temp
        public Temperature(double temperature)
        {
            SetTemperature(temperature);
            SetScale(DEFAULT_SCALE);
        }

        // Partial Constructor Scale
        public Temperature(char scale)
        {
            SetTemperature(DEFAULT_TEMPERATURE);
            SetScale(scale);
        }

        // Calls Regular Full Constructor, overloads for int parameter
        public Temperature(int temperature, char scale) : 
            this(Convert.ToDouble(temperature), scale)
        { }

        // Calls Regular Full Constructor, overloads for string parameter
        public Temperature(double temperature, string scale) :
            this(temperature, scale[0])
        { }

        // Calls Regular Full Constructor, overloads for int and string paramter
        public Temperature(int temperature, string scale) :
            this(Convert.ToDouble(temperature), scale[0])
        { }

        // Calls Regular Partial Constructor, overloads for int paramter
        public Temperature(int temperature) :
            this(Convert.ToDouble(temperature))
        { }

        // Calls Regular Partial Constructor, overloads for string paramter
        public Temperature(string scale) :
            this(scale[0])
        { }

        // Mutators
        // Sets the Temperature
        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        // Sets the Scale with perhaps the ugliest error checking I've ever done
        // Really I could have cleaned this up to be a bit nicer, but I like trying
        // new things so I left it as is
        public void SetScale(char scale)
        {
            // Variables
            bool notValid;
            char tempScale;

            // Handles invalid Scales
            switch (scale)
            {
                // Cascades all valid cases
                case ('c'):
                case ('C'):
                case ('f'):
                case ('F'):
                    this.scale = scale;
                    break;
                // Handles Invalid Cases
                default:

                    // Error Checks until valid Scale is entered
                    notValid = true;
                    do
                    {
                        try
                        {
                            // Prompts user for valid Scale
                            Console.Write("Please enter (C or F): ");
                            tempScale = Console.ReadLine()[0];

                            // Checks whether it's a valid character
                            if (tempScale == 'C' ||
                                tempScale == 'c' ||
                                tempScale == 'F' ||
                                tempScale == 'f')
                            {
                                // If it's valid, then may exit loop
                                notValid = false;
                            }
                            // If not a Valid Character give feedback
                            else
                            {
                                Console.WriteLine("\nInvalid Input");
                            }

                            // Sets newly Valid Scale
                            this.scale = tempScale;
                        }
                        // Catches Error-throwing Input due to using index of String issues
                        catch (IndexOutOfRangeException e)
                        {
                            // Gives Feedback on the Exception cause why not
                            Console.WriteLine("\nInvalid Input: " + e.Message);
                        }
                    // Exits when Valid value is given
                    } while (notValid);
                    break;
            }
        }

        // Sets both the Temperature and the Scale
        public void SetTemperatureAndScale(double temperature, char scale)
        {
            SetTemperature(temperature);
            SetScale(scale);
        }

        // Accessors
        // Gets the Temperature in Celsius
        public double GetTemperatureCelsius()
        {
            // If it's already Celsius, return the temperature
            if (GetScale() == 'C' || GetScale() == 'c')
                return this.temperature;
            // If it's not Celsius, previous error checking implies it's Fahrenheit
            else
                return Math.Round((this.temperature - 32) * 5 / 9, 1);
        }

        // Gets the Temperature in Fahrenheit
        public double GetTemperatureFahrenheit()
        {
            // If it's already Fahrenheit, return the temperature
            if (GetScale() == 'F' || GetScale() == 'f')
                return this.temperature;
            // If it's not Fahrenheit, previous error checking implies it's Celsius
            else
                return Math.Round((9 * this.temperature / 5) + 32, 1);
        }
        // Gets the Scale
        public char GetScale()
        {
            return this.scale;
        }

        // Utility Methods
        // ToString Override Method
        public override string ToString()
        {
            // Variables
            string resultString;

            // If the temperature is Celsius
            if (GetScale() == 'C' || GetScale() == 'c')
                resultString = string.Format("{0} degrees Celsius", GetTemperatureCelsius());

            // Previous Error Checking Implies Fahrenheit
            else
                resultString = string.Format("{0} degrees Fahrenheit", GetTemperatureFahrenheit());

            return resultString + "\n";
        }
        
        // Equals Method Compares Value of Temperatures
        // It shouldn't matter what scale they're in, we're just checking
        // numerical equivalence accounting for scales.
        public override bool Equals(object obj)
        {
            var OtherTemperature = obj as Temperature;
            return OtherTemperature != null &&
                   this.GetTemperatureCelsius() == OtherTemperature.GetTemperatureCelsius();
        }
    }
}
