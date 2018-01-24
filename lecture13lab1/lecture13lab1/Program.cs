using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture13lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = new Vector3D(5, 2, 8);
            Vector3D b = new Vector3D(-3, 4, -12);

            Vector3D result = a + b;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result);

            Console.WriteLine("Scalar: {0}", a * 5);

            Console.ReadKey();
        }
    }
}
