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

namespace hw8project1
{
    class Duelist
    {
        // This is here so each Next.Double() call gives a truly random value
        // Otherwise it creates a new Random Object several times a seconds all
        // of which use the same time/seed creating the same value for that second
        Random rand = new Random();

        // Constants
        private const string DEFAULT_NAME = "Kevin Lewis";
        private const double DEFAULT_HIT_CHANCE = .995;
        private const bool DEFAULT_ALIVE = true;

        // Instance Variables
        private string name;
        private double hitChance;
        private bool isAlive;

        // Full Constructor
        public Duelist(string name, double hitChance, bool isAlive)
        {
            SetAll(name, hitChance, isAlive);
        }

        // Default Constructor - Uses Full as Template
        public Duelist() :
            this(DEFAULT_NAME, DEFAULT_HIT_CHANCE, DEFAULT_ALIVE)
        { }

        // Mutators
        // Set's all the attributes at once, as all are equally necessary
        private void SetAll(string name, double hitChance, bool isAlive)
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

        // Utility Methods
        // Takes a Shot at another Player
        public bool ShootAt(Duelist target)
        {
            double missChance = rand.NextDouble();

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

        // To String Method to Summarize Duelist's Condition
        public override string ToString()
        {
            return ("Name: " + GetName() + "\n" +
                    "Hit Chance: " + Math.Round(GetHitChance() * 100, 2) + "%\n" +
                    "Alive: " + GetIsAlive());
        }

        // Equals Method to Compare Duelists by Name
        public override bool Equals(object obj)
        {
            var duelist = obj as Duelist;
            return duelist != null &&
                   name == duelist.name;
        }




    }
}
