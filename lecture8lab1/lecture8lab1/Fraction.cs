using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Fraction
    {
        // Instance Variables
        private int _numerator;
        private int _denominator;

        // Properties
        // Numerator Property
        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }
        
        // Denominator Property
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value != 0)
                    _denominator = value;
                else
                    _denominator = 1;
            }
        }

        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(Fraction fraction)
            : this(fraction._numerator, fraction._denominator)
        {

        }


        public double GetFractionValue()
        {
            return _numerator / (double)_denominator;
        }

        public int GreatestCommonFactor()
        {
            int min = Math.Min(_numerator, _denominator);
            int gcf = 1;
            for (int i = min; i > 1; i--)
            {
                if (_numerator % i == 0 && _denominator % i == 0)
                {
                    gcf = i;
                    break;
                }
            }
            return gcf;
        }

        public string ReducedFraction()
        {
            return String.Format("{0}/{1}", _numerator / GreatestCommonFactor(), _denominator / GreatestCommonFactor());
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", _numerator, _denominator);
        }
    }
}