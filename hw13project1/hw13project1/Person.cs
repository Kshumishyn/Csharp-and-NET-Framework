// Homework No.13 Exercise No.1
// File Name:     Person.cs
// @author:       Kostyantyn Shumishyn
// Date:          December 3, 2017
//
// Problem Statement: Person class with Properties

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13project1
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public double BMI { get; set; }

        // Full Constructor
        public Person(string fname, string lname, int age, int height, int weight)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            Height = height;
            Weight = weight;
            BMI = (703.0 * Weight) / (Math.Pow(Height, 2));
        }

        // To String Override
        public override string ToString()
        {
            return String.Format("{0} {1}, {2}, {3} inches, {4} pounds, {5} BMI", FirstName, LastName, Age, Height, Weight, Math.Round(BMI,2));
        }
    }
}