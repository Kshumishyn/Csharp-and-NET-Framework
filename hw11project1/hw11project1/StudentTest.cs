// Homework No.11 Exercise No.1
// File Name:     StudentTest.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 20, 2017
//
// Problem Statement: StudentTest class for storing a Student's Test

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11project1
{
    class StudentTest : IComparable
    {
        // Constants
        private const int DEFAULT_SCORE = 0;

        // Instance Variables
        private Student student;
        private int testScore;

        // Full Constructor
        public StudentTest(Student student, int testScore)
        {
            SetStudent(student);
            SetTestScore(testScore);
        }

        // Partial Constructor
        public StudentTest(string firstName, string lastName, int testScore)
            : this((new Student(firstName, lastName)), testScore) { }

        // Default Constructor
        public StudentTest () 
            : this((new Student()), DEFAULT_SCORE) { }

        // Accessors
        // Gets the Student
        public Student GetStudent()
        {
            return student;
        }

        // Gets the Test Score
        public int GetTestScore()
        {
            return testScore;
        }

        // Mutators
        // Sets the Student
        public void SetStudent(Student student)
        {
            if (student != null)
                this.student = student;
        }

        // Sets the Test Score
        public void SetTestScore(int testScore)
        {
            if (testScore < 0)
                this.testScore = 0;
            else
                this.testScore = testScore;
        }

        // Utility Methods
        // ToString Method
        public override string ToString()
        {
            return String.Format("{0,-10} | {1,-10} | {2,6}     |", student.GetFirstName(), student.GetLastName(), this.GetTestScore());
        }

        // Equals Method
        public override bool Equals(object obj)
        {
            var test = obj as StudentTest;
            return test != null &&
                   EqualityComparer<Student>.Default.Equals(student, test.student) &&
                   testScore == test.testScore;
        }

        // Implements Compareable Interface method CompareTo
        public int CompareTo(object obj)
        {
            return this.GetTestScore().CompareTo(((StudentTest)obj).GetTestScore());    
        }
    }
}
