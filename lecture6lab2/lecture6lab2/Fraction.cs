using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture6lab2
{
    class Fraction
    {
        // Instance Variables
        private int numerator;
        private int denominator;

        // Getters
        public int getNumerator()
        {
            return this.numerator;
        }

        public int getDenominator()
        {
            return this.denominator;
        }

        // Setters
        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void setDenominator(int denominator)
        {
            if (denominator != 0)
            {
                this.denominator = denominator;

            }
            else
            {
                this.denominator = 1;
            }
        }

        // Utility
        // Returns double value
        public double decimalValue()
        {
            return Math.Round((double)this.numerator / this.denominator, 2);
        }

        // Returns Greatest common Denominator
        public int greatestCommonDenominator()
        {
            int numerator = this.numerator;
            int denominator = this.denominator;

            while (numerator != 0 && denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }
            return numerator + denominator;
        }

    }
}
