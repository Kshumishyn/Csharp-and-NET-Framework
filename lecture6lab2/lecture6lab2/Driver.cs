using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture6lab2
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Variables
            Fraction newFraction = new Fraction();
            int reducedNumerator;
            int reducedDenominator;

            // Declaration
            newFraction.setNumerator(5);
            newFraction.setDenominator(20);

            // Output
            Console.WriteLine("Initial Form = {0}/{1}", newFraction.getNumerator(), newFraction.getDenominator());

            reducedNumerator = newFraction.getNumerator() / newFraction.greatestCommonDenominator();
            reducedDenominator = newFraction.getDenominator() / newFraction.greatestCommonDenominator();

            // Output
            Console.WriteLine("Greatest Common Denominator = " + newFraction.greatestCommonDenominator());
            Console.WriteLine("Decimal Value = " + newFraction.decimalValue());
            Console.WriteLine("Reduced Form = {0}/{1}", reducedNumerator, reducedDenominator);

            // Waits for Program Close
            Console.ReadLine();
        }
    }
}
