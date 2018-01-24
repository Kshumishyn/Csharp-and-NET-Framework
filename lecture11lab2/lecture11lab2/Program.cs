using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture11lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts for name of first File
            Console.WriteLine("Please enter the name of the File containing Boy's names: ");
            string boyFileName = "../../" + Console.ReadLine();
            Dictionary<string, int> maleFrequencyMap = ReadListFromFile(boyFileName);

            // Prompts for name of second File
            Console.WriteLine("Please enter the name of the File containing Girl's names: ");
            string girlFileName = "../../" + Console.ReadLine();
            Dictionary<string, int> femaleFrequencyMap = ReadListFromFile(boyFileName);

            // Asks which Gender to check for
            Console.WriteLine("\nAre you looking for a Male or Female?");
            string lookingFor = Console.ReadLine();
            bool lookMale = lookingFor.ToLower().StartsWith("m");

            // Asks which name to check for
            Console.WriteLine("\nWhat name are you looking for?");
            lookingFor = Console.ReadLine();

            if (lookMale)
            {
                if (maleFrequencyMap.TryGetValue(lookingFor, out int frequency))
                    Console.WriteLine("{0} has a frequency of {1}.", lookingFor, frequency);
                else
                    Console.WriteLine("Name is not Present on this list.");
            }
            else
            {
                if (femaleFrequencyMap.TryGetValue(lookingFor, out int frequency))
                    Console.WriteLine("\n{0} has a frequency of {1}.", lookingFor, frequency);
                else
                    Console.WriteLine("Name is not Present on this list.");
            }

            // Waits to Close Console
            Console.ReadLine();

        }

        private static Dictionary<string, int> ReadListFromFile(string filename)
        {
            // Variables
            string line;
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            // Error Handles
            try
            {
                StreamReader boyReader = new StreamReader(filename);
                
                // While each token isn't null
                while ((line = boyReader.ReadLine()) != null)
                {
                    // Stores each token into Dictionary
                    string[] lineTokens = line.Split();
                    frequencyMap.Add(lineTokens[0], Convert.ToInt32(lineTokens[1]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return frequencyMap;
        }
    }
}
