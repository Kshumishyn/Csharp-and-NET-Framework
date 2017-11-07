// Homework No.9 Exercise No.1
// File Name:     hw9project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 6, 2017
//
// Problem Statement: The Person Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9project1
{
    class Person
    {
        // Constants
        private const string DEFAULT_NAME = "Alexis";

        // Instance Variables
        private string name;

        // Full Constructor
        public Person(string name)
        {
            SetName(name);
        }

        // Default Constructor - Uses Full as Template
        public Person() : this(DEFAULT_NAME)
        { }

        // Clone Constructor
        public Person(Person toClone) : this(toClone.GetName())
        { }

        // Mutators
        // Sets the Person's Name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Accessors
        // Gets the Person's Name
        public string GetName()
        {
            return this.name;
        }

        // Utility Methods
        // To String Method for Person
        public override string ToString()
        {
            return GetName();
        }

        // Equals Method to compare two Persons
        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return person != null &&
                   name == person.name;
        }
    }
}