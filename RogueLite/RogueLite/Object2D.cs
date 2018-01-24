using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLite
{
    class Object2D
    {
        // Instance Variables
        public Vector2 Position;
        public Texture2D Texture;
        public Rectangle BoundingBox;

        // Collision Method
        public bool Colliding(Object2D obj)
        {
            // Default Collision to False
            bool col = false;

            if (BoundingBox.Intersects(obj.BoundingBox))
                col = true;
            
            return col;
        }

        public virtual void Init(Vector2 pos, Texture2D text)
        {
            Position = pos;
            Texture = text;
        }

        public virtual void Init(Vector2 pos, GraphicsDevice graphicsDevice, int canvasWidth, int canvasHeight)
        {
            Position = pos;
            Texture = new Texture2D(graphicsDevice, canvasWidth, canvasHeight);
        }

        public virtual void Update()
        {
            BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
