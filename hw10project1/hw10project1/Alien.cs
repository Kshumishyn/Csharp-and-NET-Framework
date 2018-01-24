using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10project1
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    class Alien
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        // Instance Variables
        private int health; //0 = dead, 100 = full
        private string name;

        // Full Constructor
        public Alien(int health, string name)
        {
            this.Health = health;
            this.Name = name;
        }

        // Properties
        // Health Property
        public int Health
        {
            get => health;
            // Error Checks to keep health reasonable
            set
            {
                if (value < 0)
                    value = 1;
                else if (value > 100)
                    value = 100;
                health = value;
            }
        }

        // Name Property
        public string Name
        {
            get => name;
            set => name = value;
        }

        // Utility Methods
        // Overrides ToString()
        public override string ToString()
        {
            return String.Format("Alien Name: {0}\nAlien Health: {1}", Name, Health);
        }

        // Overrides Equals
        public override bool Equals(object obj)
        {
            var alien = obj as Alien;
            return alien != null &&
                   Health == alien.Health &&
                   Name == alien.Name;
        }
    }
}
