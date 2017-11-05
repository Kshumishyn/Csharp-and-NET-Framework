// Homework No.8 Exercise No.1
// File Name:     hw8project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 30, 2017
//
// Problem Statement: Creates 3 duelists with varying chances to hit
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Creates 3 Duelists
// 2. Sends 3 Duelists into Static Method and gets back the Winner
// 3. Tests methodology of first Duelist Missing Intentionally
// 4. Returns Relevant Information about the Duel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8project1
{
    class DuelistDriver
    {
        // Constant Variables
        const int MAX_ROUNDS = 1000000;
        const bool AARON_MISS = false;

        const double DUELIST_ONE_HIT_CHANCE = (1 / 3.0);
        const double DUELIST_TWO_HIT_CHANCE = (1 / 2.0);
        const double DUELIST_THREE_HIT_CHANCE = .995;

        // Experimental Data Implies that by default
        // Aaron Win Rate = 36%
        // Bob Win Rate = 42%
        // Charlie Win Rate = 22%

        // Experiment Data with Aaron missing his First Shot Implies
        // Aaron Win Rate = 42%
        // Bob Win Rate = 25%
        // Charlie Win Rate = 33%

        // Explanation is that because Aaron Misses, the other two
        // are guaranteed to shoot eachother no matter whether Bob
        // hits or not, so Aaron only has one target to worry about
        // causing a net increase in his odds

        public static void Main(string[] args)
        {
            // Creates the 3 Duelists
            Duelist aaron = new Duelist("Aaron", DUELIST_ONE_HIT_CHANCE, true);
            Duelist bob = new Duelist("Bob", DUELIST_TWO_HIT_CHANCE, true);
            Duelist charlie = new Duelist("Charlie", DUELIST_THREE_HIT_CHANCE, true);

            // Temporary Duelist for storing winner
            Duelist winner;

            // Variables
            int numRoundsTotal = 0;

            // Aaron's Stats
            int roundsAaronWon = 0;
            double aaronWinRate = 0;

            // Bob's Stats
            int roundsBobWon = 0;
            double bobWinRate = 0;

            // Charlie's Stats
            int roundsCharlieWon = 0;
            double charlieWinRate = 0;

            // Gives the User Feedback on whether Strategy is being used
            if (AARON_MISS)
                Console.WriteLine("{0} is employing the strategy of missing their first shot!\n", aaron.GetName());

            // Runs the given number of rounds
            while (numRoundsTotal < MAX_ROUNDS)
            {
                // Revives All Duelists Before Beginning
                aaron.Respawn();
                bob.Respawn();
                charlie.Respawn();

                // Stores Duelist to update Statistics
                winner = BeginDuelistMatch(aaron, bob, charlie);

                // Checks who won and adds to their win count
                if (winner.Equals(aaron))
                    roundsAaronWon++;
                else if (winner.Equals(bob))
                    roundsBobWon++;
                else if (winner.Equals(charlie))
                    roundsCharlieWon++;

                // Increments number of Total Rounds
                numRoundsTotal++;

            }

            // Calculates Win Rates
            aaronWinRate = Math.Round((roundsAaronWon / (double)numRoundsTotal) * 100, 2);
            bobWinRate = Math.Round((roundsBobWon / (double)numRoundsTotal) * 100, 2);
            charlieWinRate = Math.Round((roundsCharlieWon / (double)numRoundsTotal) * 100, 2);

            // Prints out Relevant Information
            Console.WriteLine("{0}\nWins: {1}\nWin Rate: {2}%\n", aaron.ToString(), roundsAaronWon, aaronWinRate);
            Console.WriteLine("{0}\nWins: {1}\nWin Rate: {2}%\n", bob.ToString(), roundsBobWon, bobWinRate);
            Console.WriteLine("{0}\nWins: {1}\nWin Rate: {2}%\n", charlie.ToString(), roundsCharlieWon, charlieWinRate);
            Console.WriteLine("\nTotal Rounds Played: {0}", numRoundsTotal);

            // Prevents Program from Closing
            Console.ReadLine();
        }

        // Runs the Match, returns winner
        public static Duelist BeginDuelistMatch(Duelist duelistOne, Duelist duelistTwo, Duelist duelistThree)
        {
            // Variables
            int numDuelistsLeft = 3;
            bool shotHit;

            // Variables for Intentionally Missing
            bool duelistOneMissIntentionally = AARON_MISS;

            // Runs until there is only one Duelist Left
            while (numDuelistsLeft > 1)
            {
                // Clause for Testing Aaron missing Intentionally
                if (duelistOneMissIntentionally)
                {
                    duelistOne.SetHitChance(0);
                }

                // If the first Duelist is alive
                if (duelistOne.GetIsAlive() == true)
                {
                    // Shoots the most dangerous first
                    if (duelistThree.GetIsAlive() == true)
                        shotHit = duelistOne.ShootAt(duelistThree);

                    // Shoots at the only other
                    else
                        shotHit = duelistOne.ShootAt(duelistTwo);

                    // If shot hits decrement number of Duelists
                    if (shotHit)
                        numDuelistsLeft--;

                }

                // If the second Duelist is alive
                if (duelistTwo.GetIsAlive() == true)
                {
                    // Shoots the most dangerous first
                    if (duelistThree.GetIsAlive() == true)
                        shotHit = duelistTwo.ShootAt(duelistThree);

                    // Shoots at only other
                    else
                        shotHit = duelistTwo.ShootAt(duelistOne);

                    // If shot hits decrement number of Duelists
                    if (shotHit)
                        numDuelistsLeft--;

                }

                // If the third Duelist is alive
                if (duelistThree.GetIsAlive() == true)
                {
                    // Shoots the most dangerous first
                    if (duelistTwo.GetIsAlive() == true)
                        shotHit = duelistThree.ShootAt(duelistTwo);

                    // Shoots at only other
                    else
                        shotHit = duelistThree.ShootAt(duelistOne);

                    // If shot hits decrement number of Duelists
                    if (shotHit)
                        numDuelistsLeft--;

                }

                // Returns Aaron's hit chance back to normal and never misses again
                if (duelistOneMissIntentionally)
                {
                    duelistOneMissIntentionally = false;
                    duelistOne.SetHitChance(DUELIST_ONE_HIT_CHANCE);
                }
            }

            // If Duelist One lived return them
            if (duelistOne.GetIsAlive())
                return duelistOne;

            // If Duelist Two lived return them
            else if (duelistTwo.GetIsAlive())
                return duelistTwo;

            // If neither One or Two lived, then Duelist Three did, return them
            else
                return duelistThree;
        }
    }
}
