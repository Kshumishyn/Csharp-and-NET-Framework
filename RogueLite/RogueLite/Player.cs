using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RogueLite
{
    class Player : Object2D
    {
        // Constants
        public const float DEFAULT_MOVESPEED = 5;

        // Instance Variables
        public float hp = 100;
        public float moveSpeed = DEFAULT_MOVESPEED;
        public string facingDirection = "right";

        // Motion Variables
        bool movingUp;
        bool movingLeft;
        bool movingDown;
        bool movingRight;

        public override void Init(Vector2 pos, Texture2D text)
        {
            base.Init(pos, text);
        }

        public override void Update()
        {
            movingUp = false;
            movingLeft = false;
            movingDown = false;
            movingRight = false;

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Position.Y -= 5;
                movingUp = true;
                facingDirection = "up";
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Position.X -= 5;
                movingLeft = true;
                facingDirection = "left";
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Position.Y += 5;
                movingDown = true;
                facingDirection = "down";
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Position.X += 5;
                movingRight = true;
                facingDirection = "right";
            }

            base.Update();
        }

        public string GetFacingDirection()
        {
            return this.facingDirection;
        }

        public float GetMovementSpeed()
        {
            return this.moveSpeed;
        }

        public string GetMovementDirection()
        {
            // Up Variations
            if (movingUp && movingLeft)
                return "upleft";
            if (movingUp && movingRight)
                return "upright";
            if (movingUp)
                return "up";

            // Down Variations
            if (movingDown && movingLeft)
                return "downleft";
            if (movingDown && movingRight)
                return "downright";
            if (movingDown)
                return "down";

            // Left and Right Solo
            if (movingLeft)
                return "left";
            if (movingRight)
                return "right";
            
            return "";
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
