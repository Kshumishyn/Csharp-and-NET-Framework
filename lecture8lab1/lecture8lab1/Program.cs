using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numer;
            int denom;

            // Initialization
            numer = 20;
            denom = 60;
            
            // Makes new Fraction
            Fraction newFraction = new Fraction(numer, denom);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Your fraction is " + newFraction.ReducedFraction());
                newFraction.Numerator++;
                newFraction.Denominator++;
            }

            // Waits to close window
            Console.ReadLine();
        }
    }
}