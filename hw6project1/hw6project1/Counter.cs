using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6project1
{
    public class Counter
    {
        // Instance Variables
        private int counter;

        // Default Constructor
        public Counter()
        {
            SetCounter(0);
        }

        // Full Constructor - Commented out According to Instructions
        public Counter(int counter)
        {
            SetCounter(counter);
        }

        // Setters
        // Sets the Counter
        public void SetCounter(int counter)
        {
            if (counter < 0)
            {
                counter = 0;
            }

            this.counter = counter;
        }

        // Getters
        // Gets the Counter
        public int GetCounter()
        {
            return this.counter;
        }

        // Utility Methods
        // Increments Counter
        public void Increment()
        {
            this.counter++;

            if (counter < 0)
            {
                this.counter = 0;
            }
        }

        // Overloaded Custom Increment
        public void Increment(int increment)
        {
            this.counter += increment;

            if (counter < 0)
            {
                this.counter = 0;
            }
        }

        // Decrements Counter
        public void Decrement()
        {
            this.counter--;

            if (this.counter < 0)
            {
                this.counter = 0;
            }
        }

        // Overloaded Custom Decrement
        public void Decrement(int decrement)
        {
            this.counter -= decrement;

            if (this.counter < 0)
            {
                this.counter = 0;
            }
        }

        // Resets Counter
        public void reset()
        {
            counter = 0;
        }

        // Displays the Counter
        public void DisplayCounter()
        {
            Console.WriteLine("Counter is at " + this.counter);
        }

        // Equals Method
        public bool Equals(int otherInt)
        {
            return this.counter == otherInt;
        }

        // Method to return a String of Counter
        public override string ToString()
        {
            return this.counter + "";
        }
    }
}
