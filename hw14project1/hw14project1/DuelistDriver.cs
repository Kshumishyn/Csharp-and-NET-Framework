using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw14project1
{
    class DuelistDriver
    {
        // Begins Logging the Program
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constant Variables
        const int MAX_ROUNDS = 24;
        const int NUM_PLAYERS = 3;

        //const double DUELIST_ONE_HIT_CHANCE = (1 / 3.0);
        //const double DUELIST_TWO_HIT_CHANCE = (1 / 2.0);
        //const double DUELIST_THREE_HIT_CHANCE = .995;

        static void Main(string[] args)
        {
            // Begins Logging with a Message
            log.Info("BEGIN LOG");
            log.Info("Starting the Generic Duelist Program.\n");
            log.Info(String.Format("Rounds to Process: {0} | \nNumber of Players: {1}.\n", MAX_ROUNDS, NUM_PLAYERS));

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

            log.Info("Beginning Iteration of Rounds");

            // Runs the given number of rounds
            try
            {
                while (numRoundsTotal < MAX_ROUNDS)
                {
                    // Revives All Duelists Before Beginning
                    foreach (Duelist temp in ourDuelists)
                        temp.Respawn();

                    // Stores Duelist to update Statistics
                    winner = BeginDuelistMatch(ourDuelists);

                    // Checks who won and adds to their win count
                    winner.AddWin();

                    // Increments number of Total Rounds
                    numRoundsTotal++;
                }
            }
            // Catches any potential problems during Rounds and Logs them
            catch (Exception e)
            {
                log.Error("Ran into Error while Iterating Rounds:\n" + e);
                Environment.Exit(0);
            }
            // Logs successful completion of Rounds
            finally
            {
                log.Info("Successfully Carried out Rounds.\n");
            }

            // Calculates Win Rates
            foreach (Duelist temp in ourDuelists)
                temp.CalculateWinRate(numRoundsTotal);

            // Prints out Relevant Information
            foreach (Duelist temp in ourDuelists)
                Console.WriteLine(temp.ToString() + "\n");

            // Prints Out General Information
            Console.WriteLine("\nTotal Rounds Played: {0}", numRoundsTotal);

            // Logs Completion of Program
            log.Info("Duelist Simulation has completed Successfully. \nEND LOG.\n\n");

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