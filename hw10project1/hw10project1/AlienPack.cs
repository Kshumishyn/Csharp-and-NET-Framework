using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{
    class AlienPack
    {
        // Instance Variable
        private Alien[] aliens;

        // Default/Full Constructor
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        // Adds an Alien with an Index
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        // Returns the list of Aliens
        public Alien[] GetAliens()
        {
            return aliens;
        }

        // Calculates the Damage Inflicted by the pack
        public int CalculateDamage()
        {
            int damage = 0;

            // Increments Damage until all aliens accounted for
            foreach (Alien minion in aliens)
            {
                if (minion is SnakeAlien)
                    damage += ((SnakeAlien) minion).GetDamage();
                
                else if (minion is OgreAlien)
                    damage += ((OgreAlien)minion).GetDamage();

                else if (minion is MarshmallowAlien)
                    damage += ((MarshmallowAlien)minion).GetDamage();
            }
            // Returns cumulative damage
            return damage;
        }

    }
}
