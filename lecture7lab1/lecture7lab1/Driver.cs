// Homework No.? Exercise No.?
// File Name:     lecture7lab1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 16, 2017
//
// Problem Statement: Makes a Student Record
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Look it just works :( I'm tired of coughing and want to go home


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture7lab1
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Variables
            int quiz1 = 7;
            int quiz2 = 10;
            int quiz3 = 10;

            int[] quizList = { quiz1, quiz2, quiz3 };

            int midtermScore = 100;
            int finalScore = 100;

            // Makes Record based on that
            StudentRecord myRecord = new StudentRecord(quizList, midtermScore, finalScore);

            // Gives Console Feedback
            Console.WriteLine("Your Overall Score is " + myRecord + " which is a(n) " + myRecord.calculateLetterGrade());

            // Waits for Console Close
            Console.ReadLine();
        }
    }
}
