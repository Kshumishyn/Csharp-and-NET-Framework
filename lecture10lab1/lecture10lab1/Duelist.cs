// Homework No.8 Exercise No.1
// File Name:     hw8project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          October 30, 2017
//
// Problem Statement: The Duelist Class with instance variables for Name, Hit Chance and Liveliness
// This class also holds the various Utility Methods pertaining to that of a Duelist.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture10lab1
{
    class Duelist : IComparable
    {
        // This is here so each Next.Double() call gives a truly random value
        // Otherwise it creates a new Random Object several times a seconds all
        // of which use the same time/seed creating the same value for that second
        static Random myRandom = new Random();

        // Constants
        private const string DEFAULT_NAME = "Kevin Lewis";
        private const double DEFAULT_HIT_CHANCE = .995;
        private const bool DEFAULT_ALIVE = true;

        // Instance Variables
        private string name;
        private double hitChance;
        private bool isAlive;
        private int wins;
        private double winRate;


        // Full Constructor
        public Duelist(string name, double hitChance, bool isAlive)
        {
            SetAll(name, hitChance, isAlive, 0, 0);
        }

        // Default Constructor - Uses Full as Template
        public Duelist() :
            this(DEFAULT_NAME, DEFAULT_HIT_CHANCE, DEFAULT_ALIVE)
        { }

        // Random Constructor
        public Duelist(int name) : this("Duelist #" + name, myRandom.NextDouble(), true)
        { }

        // Mutators
        // Set's all the attributes at once, as all are equally necessary
        private void SetAll(string name, double hitChance, bool isAlive, int wins, double winRate)
        {
            this.name = name;
            this.hitChance = hitChance;
            this.isAlive = isAlive;
        }

        // Set's Hit chance for Aaron Test, no other purpose
        public void SetHitChance(double hitChance)
        {
            this.hitChance = hitChance;
        }

        // Gruesome Method for those with a strong heart
        public void Kill()
        {
            isAlive = false;
        }

        // Divine Method
        public void Respawn()
        {
            isAlive = true;
        }
        
        // Increments Wins
        public void AddWin()
        {
            this.wins++;
        }

        // Accessors
        // Returns this Duelist's Name
        public string GetName()
        {
            return name;
        }

        // Returns this Duelist's Hit Chance
        public double GetHitChance()
        {
            return hitChance;
        }

        // Returns this Duelist's state of mind
        public bool GetIsAlive()
        {
            return isAlive;
        }

        // Returns this Duelist's number of wins
        public int GetWins()
        {
            return wins;
        }

        // Returns this Duelist's win rate
        public double GetWinRate()
        {
            return winRate;
        }

        // Utility Methods
        // Finds a Target to shoot at given a List
        public Duelist FindTarget(List<Duelist> targetList, Duelist currentShooter)
        {
            // Variables
            Duelist toShoot = null;
            int listSize = targetList.Count;
            bool foundTarget = false;

            while (!foundTarget)
            {
                // Goes through the list in reverse
                for (int i = targetList.Count - 1; i >= 0; i--)
                {
                    Duelist target = targetList[i];
                    if (target.GetIsAlive() && !target.Equals(currentShooter))
                    {
                        toShoot = target;
                        foundTarget = true;
                        break;
                    }
                }
            }

            return toShoot;
        }

        // Takes a Shot at another Player
        public bool ShootAt(Duelist target)
        {
            double missChance = myRandom.NextDouble();

            // For making sure Miss Chance is random
            //Console.WriteLine("\n\n-----" + missChance + "-----\n\n");

            if (GetHitChance() > missChance)
            {
                target.Kill();
                return true;
            }
            else
                return false;
        }

        // Takes in Total Number of Rounds Played to Calculate their Winrate
        public double CalculateWinRate(int totalRoundsPlayed)
        {
            this.winRate = Math.Round((GetWins() / (double)totalRoundsPlayed) * 100, 2);

            return winRate;
        }

        // To String Method to Summarize Duelist's Condition
        public override string ToString()
        {
            return ("Name: " + GetName() + "\n" +
                    "Hit Chance: " + Math.Round(GetHitChance() * 100, 2) + "%\n" +
                    "Alive: " + GetIsAlive()) + "\n" +
                    "Wins: " + GetWins() + "\n" +
                    "Winrate: " + GetWinRate();
        }

        // Equals Method to Compare Duelists by Name
        public override bool Equals(object obj)
        {
            var duelist = obj as Duelist;
            return duelist != null &&
                   name == duelist.name;
        }

        // Interface CompareTo method
        public int CompareTo(object obj)
        {
            // If other is an Object, Duelist is greater
            if (obj == null)
                return 1;

            // Checks to make sure other is a Duelist
            if (obj is Duelist otherDuelist)
                return this.hitChance.CompareTo(otherDuelist.hitChance);
            
            // Throws Exception
            else
                throw new ArgumentException("Object is not a Duelist");
        }
    }
}
