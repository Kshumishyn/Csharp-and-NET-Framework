/// Chapter No. 1		Exercise No. 1
/// File Name: MyFirstProgram.java
/// @author: Bill Gates
/// Date:  August 24, 2015
///
/// Problem Statement: Ask the user to enter two numbers, calculate the sum of
/// these two numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for two integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will do some basic arithmetic for you!");
            Console.WriteLine("Enter three numbers, pressing enter after each one");

            // declare two integer variables
            int n1, n2, n3, sum, product;

            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of these three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of these three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("The sum divided by the product is");
            Console.WriteLine((double)sum / product);   //Typecasting

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}