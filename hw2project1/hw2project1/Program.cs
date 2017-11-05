// Homework No.2 Exercise No.1
// File Name:     hw2project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          September 1, 2017
//
// Problem Statement: Takes a first and last name and translates it to pig latin
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Take first and last name, start them off lowercase
// 2. Take 2nd letter of the word as its own String, Uppercase it then concetenate it
//    with the rest of the word and add the first letter to the end with the string "ay"
// 3. Do above for first and last name Strings, then put back together and print out

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2project1
{
    class Program
    {
        // Constants
        public const string FIRST_NAME = "Kevin";
        public const string LAST_NAME = "Lewis";

        static void Main(string[] args)
        {
            // Declaration
            string firstName = FIRST_NAME;
            string lastName  = LAST_NAME;
            string pigLatinFirst;
            string pigLatinLast;
            string pigLatinFinal;

            // Info Message
            Console.WriteLine("Your name is {0} {1}, right?", firstName, lastName);

            // Substring 1 to 1 so can use ToUpper
            // Using single bound for Substring goes to end
            // ElementAt returns a Char that concatenates into String but can't accept ToUpper or ToLower so lowercase beforehand
            pigLatinFirst = firstName.ToLower();
            pigLatinFirst = pigLatinFirst.Substring(1, 1).ToUpper() + pigLatinFirst.Substring(2) + pigLatinFirst.ElementAt(0) + "ay";

            pigLatinLast  = lastName.ToLower();
            pigLatinLast  = pigLatinLast.Substring(1, 1).ToUpper()  + pigLatinLast.Substring(2)  + pigLatinLast.ElementAt(0)  + "ay";

            // Puts first and last name together and prints
            pigLatinFinal = pigLatinFirst + " " + pigLatinLast;
            Console.WriteLine("Your name in Pig Latin would be {0}! How strange!", pigLatinFinal);

            // Delays Console closing
            Console.ReadLine();            
        }
    }
}
