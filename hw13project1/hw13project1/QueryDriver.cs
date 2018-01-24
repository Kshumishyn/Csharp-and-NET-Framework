// Homework No.13 Exercise No.1
// File Name:     QueryDriver.cs
// @author:       Kostyantyn Shumishyn
// Date:          December 3, 2017
//
// Problem Statement: Tries out Queries for a list of Persons with BMI's
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Creates a large list of Persons
// 2. Separates the Persons who are overweight and prints them.
// 3. Separates the Persons who are healthy and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13project1
{
    class QueryDriver
    {
        static void Main(string[] args)
        {
            // Initializes List
            List<Person> allPeople = new List<Person>();

            // Creates a List of 15 People
            allPeople.Add(new Person("Kostyantyn", "Shumishyn", 23, 73, 190));
            allPeople.Add(new Person("Mike", "Jones", 31, 70, 173));
            allPeople.Add(new Person("Eric", "Parson", 18, 66, 140));
            allPeople.Add(new Person("Alina", "Kim", 19, 67, 130));
            allPeople.Add(new Person("Brandon", "Hong", 19, 72, 178));
            allPeople.Add(new Person("Paul", "Lee", 25, 67, 165));
            allPeople.Add(new Person("Lemee", "Nakamura", 43, 60, 110));
            allPeople.Add(new Person("Kevin", "Lewis", 37/*?*/, 72/*??*/, 180/*???*/));
            allPeople.Add(new Person("Steve", "Manson", 12, 54, 80));
            allPeople.Add(new Person("Park", "Pesk", 23, 66, 150));
            allPeople.Add(new Person("Gale", "Smith", 30, 70, 190));
            allPeople.Add(new Person("Helga", "Brown", 56, 30, 190));
            allPeople.Add(new Person("Irma", "Hamil", 67, 83, 190));
            allPeople.Add(new Person("Jasmine", "Watson", 78, 57, 190));
            allPeople.Add(new Person("Kara", "Clark", 18, 64, 120));
            allPeople.Add(new Person("Laura", "Legend", 100, 84, 200));

            // Queries Overweight People
            IEnumerable<Person> overweight = from person in allPeople
                                             where person.BMI > 25
                                             select person;

            // Prints Overweight People
            Console.WriteLine("Printing all Overweight people.");
            foreach (Person adult in overweight)
                Console.WriteLine("- " + adult);

            // Queries Healthy People
            IEnumerable<Person> ideal = from person in allPeople
                                        where person.BMI > 20
                                        where person.BMI < 25
                                        select person;

            // Prints Healthy People
            Console.WriteLine("\nPrinting all Healthy people.");
            foreach (Person responsiblePerson in ideal)
                Console.WriteLine("- " + responsiblePerson);

            // Waits to Close console
            Console.ReadKey();
        }
    }
}