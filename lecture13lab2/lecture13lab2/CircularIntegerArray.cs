using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture13lab2
{
    class CircularIntegerArray
    {
        // Instance Variables
        private int[] intArray;
        private int numFilled;
        private int maxArraySize;

        // Full Constructor
        public CircularIntegerArray(int arraySize)
        {
            maxArraySize = arraySize;
            numFilled = 0;
            intArray = new int[arraySize];
        }

        // Accessors
        // Get Max Size
        public int GetMaxArraySize()
        {
            return this.maxArraySize;
        }

        // Get the Array
        public int[] GetIntArray()
        {
            return this.intArray;
        }

        // Get the Index Value
        public int GetValue(int index)
        {
            return GetIntArray()[index];
        }

        // Mutators
        // Set the Index Value
        public void SetValue(int index, int value)
        {
            intArray[index] = value;
        }

        // Utility Methods
        // Adds to Array
        public void add(int value)
        {
            this.intArray[numFilled % maxArraySize] = value;
            numFilled++;
        }

        // To String
        public override string ToString()
        {
            // Variables
            string result = "[";
            int i;

            for (i = 0; i < intArray.Length - 1; i++)
                result += intArray[i] + ", ";

            result += intArray[i] + "]";

            return result;
        }

        //

        // Overloads Index Operator
        public int this[int key]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                SetValue(key, value);
            }
        }
    }
}
