// Homework No.11 Exercise No.1
// File Name:     StudentDriver.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 20, 2017
//
// Problem Statement: Create a means of Storing a list of Students from a File and finding statistics about their Test Scores
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Creates new Test Statistic
// 2. Reads List of Student Tests from File
// 3. Adds each Student Test to Statistic Dictionary
// 4. Calculates Statistics/Average/Median of that Dictionary
// 5. Writes useful information to File in pretty manner

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11project1
{
    class StudentDriver
    {
        static void Main(string[] args)
        {
            // Creates new StudentTestStats
            StudentTestStats classTestStatistics = new StudentTestStats();

            // Creates List of Student Tests from File
            List<StudentTest> studentTestList = ReadListFromFile("studentList.txt");

            // Adds each StudentTest to the Stats Class
            foreach (StudentTest test in studentTestList)
                classTestStatistics.AppendTest(test);

            // Gets the Average Score and the Median
            double averageScore = Math.Round(classTestStatistics.GetAverageScore(), 2);
            double medianScore = Math.Round(classTestStatistics.GetMedianTestScore(), 2);

            // Writes Statistics to File w/ Error Handling
            try
            {
                // Creates Stream Writer
                StreamWriter sw = new StreamWriter("StudentStats.txt");

                // Writes Header
                sw.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5} |", "First Name", "Last Name", "Test Score"));
                sw.WriteLine("-----------|------------|------------|");

                // Writes Each Student Test to File
                foreach (KeyValuePair<Student, StudentTest> entry in classTestStatistics.GetTestList())
                    sw.WriteLine(entry.Value.ToString());

                // Writes Stats info
                sw.WriteLine("--------------------------------------");
                sw.WriteLine("Average Test Score : " + averageScore);
                sw.WriteLine("Median Test Score  : " + medianScore);

                // Closes StreamWriter
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static List<StudentTest> ReadListFromFile(string filename)
        {
            // Variables
            string line;
            List<StudentTest> studentTestList = new List<StudentTest>();

            // Error Handles
            try
            {
                // Creates a Stream Reader
                StreamReader sr = new StreamReader(filename);

                // While each token isn't null
                while ((line = sr.ReadLine()) != null)
                {
                    // Stores each token into Dictionary
                    string[] lineTokens = line.Split();

                    // Creates a Student Test List out of the Student List
                    studentTestList.Add(new StudentTest(new Student(lineTokens[0], lineTokens[1]), Convert.ToInt32(lineTokens[2])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return studentTestList;
        }
    }
}

