using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{
    class OgreAlien : Alien
    {
        // Constants
        const int OGRE_DAMAGE = 6;

        // Base Constructor of Parent
        public OgreAlien(int health, string name) : base(health, name)
        { }

        // Gets the Alien Specific Damage
        public int GetDamage()
        {
            return OGRE_DAMAGE;
        }

        // Utility Methods
        // Overrides ToString()
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
