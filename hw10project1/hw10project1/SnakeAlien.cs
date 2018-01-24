using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{
    class SnakeAlien : Alien
    {
        // Constants
        const int SNAKE_DAMAGE = 10;

        // Base Constructor of Parent
        public SnakeAlien(int health, string name) : base(health, name)
        { }

        // Gets the Alien Specific Damage
        public int GetDamage()
        {
            return SNAKE_DAMAGE;
        }

        // Utility Methods
        // Overrides ToString()
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
