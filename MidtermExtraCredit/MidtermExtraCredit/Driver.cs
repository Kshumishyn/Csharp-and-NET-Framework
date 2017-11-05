// Extra Credit No.? Exercise No.1
// File Name:     MidtermExtraCredit.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 16, 2017
//
// Problem Statement: Create a basic Game Infrastructure
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Depending on Global Constant, test either Default Constructor or Full Constructor
// 2. If testing default Constructor, simply make a new game which makes a new player
//    and prints out the toString of the game which prints out the player list which
//    prints out the toString of each player
// 3. If testing full Constructor, make up to four (configurable) new players all with
//    customized information. Then add them all to list and pass that list as a parameter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Driver
    {
        const bool TEST_DEFAULT_TOGGLE = true;

        public static void Main(String[] args)
        {
            // Tests Default Case
            if (TEST_DEFAULT_TOGGLE)
            {
                // Creates default game Object
                Game newGame = new Game();

                // Prints Default Constructor of a Game
                Console.WriteLine(newGame);
            }

            // Full Constructor Test
            else
            {
                Player[] playerList = new Player[4];

                Player firstPlayer = new Player("Kostyantyn Shumishyn", 'M');
                playerList[0] = firstPlayer;

                Player secondPlayer = new Player("Eric Parsons", 'M');
                playerList[1] = secondPlayer;

                Player thirdPlayer = new Player("Michael Jones", 'M');
                playerList[2] = thirdPlayer;

                Player fourthPlayer = new Player("Lemee Nakamura", 'F');
                playerList[3] = fourthPlayer;

                Game myGame = new Game("Mario Party 5!", 4, playerList);

                // Prints Default Constructor of a Game
                Console.WriteLine(myGame);
            }

            // Waits before closing Program
            Console.ReadLine();


        }
    }
}
