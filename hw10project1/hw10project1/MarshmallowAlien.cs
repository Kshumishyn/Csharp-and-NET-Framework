using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{
    class MarshmallowAlien : Alien
    {
        // Constants
        const int MARSHMALLOW_DAMAGE = 1;

        // Base Constructor of Parent
        public MarshmallowAlien(int health, string name) : base(health, name)
        { }

        // Gets the Alien Specific Damage
        public int GetDamage()
        {
            return MARSHMALLOW_DAMAGE;
        }

        // Utility Methods
        // Overrides ToString()
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
