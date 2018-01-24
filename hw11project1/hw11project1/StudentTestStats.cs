// Homework No.11 Exercise No.1
// File Name:     StudentTestStats.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 20, 2017
//
// Problem Statement: StudentTestStats class for calculating Statistics related to the StudentTests

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11project1
{
    class StudentTestStats
    {
        // Instance Variable
        private Dictionary<Student, StudentTest> testDictionary;

        // Full Constructor
        public StudentTestStats()
        {
            testDictionary = new Dictionary<Student, StudentTest>();
        }

        // Accessor
        // Gets Dictionary of TestList
        public Dictionary<Student, StudentTest> GetTestList()
        {
            return this.testDictionary;
        }

        // Utility Methods
        // Adds to Dictionary
        public void AppendTest(StudentTest newTest)
        {
            testDictionary.Add(newTest.GetStudent(), newTest);
        }

        // Gets the Average of Test Scores
        public double GetAverageScore()
        {
            // Return variable
            double average = 0;

            // Checks that Dictionary isn't empty
            if (testDictionary.Count > 0)
            {
                // Iterates through Dictionary and sums
                foreach (KeyValuePair<Student, StudentTest> entry in testDictionary)
                    average += entry.Value.GetTestScore();

                // Safely divides by total entries
                average /= testDictionary.Count;
            }

            // Returns either 0 if empty Dictionary or the correct Average
            return average;
        }

        // Gets the Median of Test Scores
        public double GetMedianTestScore()
        {
            // Return variable
            double median = 0;

            // Creates a List from Dictionary
            List<StudentTest> testList = new List<StudentTest>();
            foreach (KeyValuePair<Student, StudentTest> entry in testDictionary)
                testList.Add(entry.Value);

            // Sorts List of Tests using compareTo method of StudentTest
            testList.Sort();

            // Determines Median
            // Handles Zero Case
            if (testList.Count == 0)
                median = 0;
            // Handles Odd Cases where median is middle value
            else if (testList.Count % 2 != 0)
                median = testList[testList.Count / 2].GetTestScore();
            // Handles Even Cases where median is average of middle values
            else
                median = (testList[testList.Count / 2].GetTestScore() + testList[(testList.Count / 2) - 1].GetTestScore()) / 2;
            
            // Returns 0 if Empty or actual Median
            return median;
        }
    }
}
