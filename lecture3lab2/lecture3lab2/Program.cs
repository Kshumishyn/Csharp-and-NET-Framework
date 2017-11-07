using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            Boolean lampWork;
            Boolean lampPluggedIn;
            Boolean bulbBurnedOut;

            // Stores response
            string temp;

            // 1st Prompt
            Console.Write("Is the lamp working (y/n)? ");
            temp = Console.ReadLine();
            lampWork = temp == "y";

            if (!lampWork)
            {
                
                // 2nd Prompt
                Console.Write("Is the lamp plugged in (y/n)? ");
                temp = Console.ReadLine();
                lampPluggedIn = temp == "y";


                if(!lampPluggedIn)
                {
                    Console.WriteLine("PLUG IT IN");
                }
                else
                {
                    // 3rd Prompt
                    Console.Write("Is the bulb burnt out (y/n)? ");
                    temp = Console.ReadLine();
                    bulbBurnedOut = temp == "y";

                    if(!bulbBurnedOut)
                    {
                        Console.WriteLine("REPAIR YOUR LAMP");
                    }
                    else
                    {
                        Console.WriteLine("REPLACE YOUR BULB");
                    }
                }
            }
            else
            {
                Console.WriteLine("YOUR LAMP WORKS");
            }

            Console.ReadLine();
        }
    }
}
