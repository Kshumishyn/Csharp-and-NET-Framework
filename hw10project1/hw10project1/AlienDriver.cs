// Homework No.10 Exercise No.1
// File Name:     hw10project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 13, 2017
//
// Problem Statement: Makes an Alien Pack and Tests their Methods/Properties and Inheritance
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Creates Regular Aliens
// 2. Creates a Misfit Alien to emulate Downcasting
// 3. Adds all Aliens to AlienPack
// 4. Prints out Info on all Aliens
// 5. Prints out the Damage the AlienPack will do

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{ 
    class AlienDriver
    {
        static void Main(string[] args)
        {
            // Creates a Pack of Aliens
            SnakeAlien hissyFit = new SnakeAlien(150, "His C. Fit");
            OgreAlien allOgre = new OgreAlien(150, "Itzal Ogre");
            MarshmallowAlien mellowMarsh = new MarshmallowAlien(150, "Mel O. Marsh");

            // Tests Downcasting - Nobody likes chuck
            Alien chuck = new OgreAlien(-50, "Chuck");

            // Adds Aliens to Pack
            AlienPack teamPuntastic = new AlienPack(4);
            teamPuntastic.AddAlien(hissyFit, 0);
            teamPuntastic.AddAlien(allOgre, 1);
            teamPuntastic.AddAlien(mellowMarsh, 2);
            teamPuntastic.AddAlien(chuck, 3);

            // Prints each Alien to make sure it's in list
            foreach (Alien alien in teamPuntastic.GetAliens())
                Console.WriteLine(alien + "\n");

            // Prints Pack Damage - Should be 23 if Chuck is Correctly understood as an Ogre
            Console.WriteLine("Pack's Damage per Attack is : {0}", teamPuntastic.CalculateDamage());

            // Waits to Close Console
            Console.ReadLine();
        }
    }
}
