using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture7lab1
{
    class StudentRecord
    {
        // Constants
        const double QUIZ_WEIGHT = .25;
        const double MIDTERM_WEIGHT = .35;
        const double FINAL_WEIGHT = .40;
        const int NUM_QUIZZES = 3;

        const int MAX_QUIZ_TOTAL_SCORE = 30;
        const int MAX_MIDTERM_SCORE = 100;
        const int MAX_FINAL_SCORE = 100;

        // Instance Variables
        private int quizTotal;
        private int[] quizzes = new int[NUM_QUIZZES];
        private int midtermTotal;
        private int finalTotal;
        private double overallTotal;

        // Default Constructor
        public StudentRecord()
        {
            this.quizTotal = 30;
            this.midtermTotal = 100;
            this.finalTotal = 100;
            this.overallTotal = Math.Round(calculateOverallTotal(30, 100, 100), 2);
        }

        // Full Constructor
        public StudentRecord(int[] listQuizzes, int midtermScore, int finalScore)
        {
            // Variables
            int tempQuizzes = calculateQuizTotal(listQuizzes);
            SetQuizTotal(tempQuizzes);
            SetMidtermTotal(midtermScore);
            SetFinalTotal(finalScore);
            SetOverallTotal(calculateOverallTotal(tempQuizzes, midtermScore, finalScore));
        }


        // Setters
        // Sets Quiz Total
        public void SetQuizTotal(int value)
        {
            if (value < 0)
            {
                value = 0;
            }

            quizTotal = value;
        }

        // Sets Quiz List
        public void SetQuizzes(int[] value)
        {
            quizzes = value;
        }

        // Sets Midterm Total
        public void SetMidtermTotal(int value)
        {
            if (value < 0)
            {
                value = 0;
            }

            midtermTotal = value;
        }

        // Sets Final Total
        public void SetFinalTotal(int value)
        {
            if (value < 0)
            {
                value = 0;
            }

            finalTotal = value;
        }

        // Sets Overall Total
        public void SetOverallTotal(double value)
        {
            if (value < 0)
            {
                value = 0;
            }

            overallTotal = Math.Round(value, 2);
        }

        // Getters
        // Gets Quiz Total
        public int GetQuizTotal()
        {
            return quizTotal;
        }

        // Gets List of Quizzes
        public int[] GetQuizzes()
        {
            return quizzes;
        }

        // Gets Midterm Total
        public int GetMidtermTotal()
        {
            return midtermTotal;
        }

        // Gets Final Total
        public int GetFinalTotal()
        {
            return finalTotal;
        }

        // Gets Overall Total
        public double GetOverallTotal()
        {
            return Math.Round(overallTotal,2);
        }

        // Utility
        // Calculates total Quiz Score from a list of Quizzes
        public int calculateQuizTotal(int[] listQuizzes)
        {
            // Variables
            int tempQuiz = 0;

            // Sums the Quizzes
            foreach (int quizScore in listQuizzes)
            {
                if (quizScore >= 0)
                    tempQuiz += quizScore;
            }

            // Returns total value of quizzes
            return tempQuiz;
        }

        // Calculates Overall Total with weighted Values
        public double calculateOverallTotal(int quizTotal, int midtermTotal, int finalTotal)
        {
            // Variables
            double tempOverall = 0;

            tempOverall += ((double)quizTotal / MAX_QUIZ_TOTAL_SCORE * QUIZ_WEIGHT);
            tempOverall += ((double)midtermTotal / MAX_MIDTERM_SCORE * MIDTERM_WEIGHT);
            tempOverall += ((double)finalTotal / MAX_FINAL_SCORE * FINAL_WEIGHT);

            // Returns overall total
            return tempOverall * 100;
        }

        // Calculates Letter Grade
        public string calculateLetterGrade()
        {
            if (this.overallTotal >= 90)
            {
                return "A";
            }
            else if (this.overallTotal >= 80)
            {
                return "B";
            }
            else if (this.overallTotal >= 70)
            {
                return "C";
            }
            else if (this.overallTotal >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        // Equals Method
        public override bool Equals(object obj)
        {
            var record = obj as StudentRecord;
            return record != null &&
                   overallTotal == record.overallTotal;
        }

        // ToString Method
        public override string ToString()
        {
            // Variables
            string result = "";

            result += Convert.ToString(GetOverallTotal());

            return result;
        }
    }
}
