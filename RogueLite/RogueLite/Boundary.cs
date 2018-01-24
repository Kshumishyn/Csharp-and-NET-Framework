using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLite
{
    class Boundary : Object2D
    {
        // Instance Variable Property
        public string Side { get; set; }

        // Personal Update Method for Boundary
        public virtual void Update(int canvasWidth, int canvasHeight)
        {
            if (Side.ToLower().Equals("up"))
                BoundingBox = new Rectangle(0, 0, canvasWidth + 1, 10);

            else if (Side.ToLower().Equals("down"))
                BoundingBox = new Rectangle(0, canvasHeight - 10, canvasWidth + 1, 10);

            else if (Side.ToLower().Equals("left"))
                BoundingBox = new Rectangle(0, 0, 10, canvasHeight + 1);

            else if (Side.ToLower().Equals("right"))
                BoundingBox = new Rectangle(canvasWidth - 10, 0, 10, canvasHeight + 1);
        }
    }
}
