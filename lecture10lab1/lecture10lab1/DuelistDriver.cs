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

namespace lecture10lab1
{
    class DuelistDriver
    {
        // Constant Variables
        const int MAX_ROUNDS = 1000000;
        const int NUM_PLAYERS = 7;

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
            // Creates the Duelists
            List<Duelist> ourDuelists = new List<Duelist>();
            Duelist winner;

            // Variables
            int numRoundsTotal = 0;

            // Adds People to List
            for (int i = 0; i < NUM_PLAYERS; i++)
                ourDuelists.Add(new Duelist(i));

            //ourDuelists.Add(new Duelist("Aaron", DUELIST_ONE_HIT_CHANCE, true));
            //ourDuelists.Add(new Duelist("Bob", DUELIST_TWO_HIT_CHANCE, true));
            //ourDuelists.Add(new Duelist("Charlie", DUELIST_THREE_HIT_CHANCE, true));

            // Runs the given number of rounds
            while (numRoundsTotal < MAX_ROUNDS)
            {
                // Revives All Duelists Before Beginning
                foreach (Duelist temp in ourDuelists)
                {
                    temp.Respawn();
                }
                // Stores Duelist to update Statistics
                winner = BeginDuelistMatch(ourDuelists);

                // Checks who won and adds to their win count
                winner.AddWin();

                // Increments number of Total Rounds
                numRoundsTotal++;
            }

            // Calculates Win Rates
            foreach (Duelist temp in ourDuelists)
                temp.CalculateWinRate(numRoundsTotal);

            // Prints out Relevant Information
            foreach (Duelist temp in ourDuelists)
                Console.WriteLine(temp.ToString() + "\n");
                
            // Prints Out General Information
            Console.WriteLine("\nTotal Rounds Played: {0}", numRoundsTotal);

            // Prevents Program from Closing
            Console.ReadLine();
        }

        // Runs the Match, returns winner
        public static Duelist BeginDuelistMatch(List<Duelist> duelistList)
        {
            // Variables
            int numDuelistsLeft = duelistList.Count;

            // Sorts List
            duelistList.Sort();

            // Runs until there is only one Duelist Left
            while (numDuelistsLeft > 1)
            {
                foreach (Duelist currentShooter in duelistList)
                {
                    if (currentShooter.GetIsAlive())
                    {
                        // Finds Target
                        Duelist target = currentShooter.FindTarget(duelistList, currentShooter);
                        
                        // Shoots at Target
                        if (currentShooter.ShootAt(target))
                            numDuelistsLeft--;                        
                    }
                }
            }

            foreach (Duelist winner in duelistList)
                if (winner.GetIsAlive())
                    return winner;

            // Unreachable
            return null;
        }
    }
}