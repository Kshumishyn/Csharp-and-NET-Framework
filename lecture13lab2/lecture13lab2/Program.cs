using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture13lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularIntegerArray circArray = new CircularIntegerArray(5);

            circArray.add(1);
            circArray.add(2);
            circArray.add(3);
            circArray.add(4);
            circArray.add(5);
            circArray.add(6);

            Console.WriteLine(circArray.ToString());

            Console.ReadLine();
        }
    }
}
