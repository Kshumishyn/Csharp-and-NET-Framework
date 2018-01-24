using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLite
{
    class Projectile : Object2D
    {
        // Instance Variable Property
        public string Direction { get; set; }

        // Personal Update Method for Boundary
        public override void Update()
        {
            // Calls Parent's Update
            base.Update();

            if (Direction.Equals("up"))
                Position.Y -= 15;
            else if (Direction.Equals("down"))
                Position.Y += 15;
            else if (Direction.Equals("left"))
                Position.X -= 15;
            else if (Direction.Equals("right"))
                Position.X += 15;
        }
    }


}
