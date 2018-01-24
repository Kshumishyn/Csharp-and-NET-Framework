// Homework No.11 Exercise No.1
// File Name:     Student.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 20, 2017
//
// Problem Statement: Student class for the Student Object containing a First and Last name

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11project1
{
    class Student
    {
        // Constants
        private const string DEFAULT_FIRST = "Marty";
        private const string DEFAULT_LAST = "Graw";

        // Instance Variables
        private string firstName;
        private string lastName;

        // Full Constructor
        public Student(string firstName, string lastName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
        }

        // Default Constructor
        public Student() : this(DEFAULT_FIRST, DEFAULT_LAST) { }

        // Accessors
        // Gets First Name
        public string GetFirstName()
        {
            return firstName;
        }

        // Gets Last Name
        public string GetLastName()
        {
            return lastName;
        }

        // Mutators
        // Sets First Name
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        // Sets Last Name
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        // Utility Methods
        // ToString Method
        public override string ToString()
        {
            return GetFirstName() + " " + GetLastName();
        }

        // Equals Method
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   firstName == student.firstName &&
                   lastName == student.lastName;
        }

    }
}
