using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace RogueLite
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        // Constants
        public const int CANVAS_WIDTH  = 1280;
        public const int CANVAS_HEIGHT = 720;

        // Rendering Variables
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D playerSprite;
        Texture2D wallSprite;
        Texture2D projectileSprite;
        Player mainPlayer = new Player();
        Obstruction wall = new Obstruction();
        Vector2 playerSpritePosition = Vector2.Zero;
        List<Object2D> fourBoundaries = new List<Object2D>();
        List<Object2D> projectileList = new List<Object2D>();
        Projectile tempProjectile = new Projectile();
        Texture2D boundaryTextures;

        public Game1()
        {
            // Creates Renderer
            graphics = new GraphicsDeviceManager(this) {  PreferredBackBufferWidth = CANVAS_WIDTH, PreferredBackBufferHeight = CANVAS_HEIGHT };

            // Default Starting Position
            mainPlayer.Position.X = 100;
            mainPlayer.Position.Y = (CANVAS_HEIGHT/2) - 25;

            // Creates Boundaries
            fourBoundaries.Add(new Boundary { Side = "up" });
            fourBoundaries.Add(new Boundary { Side = "down" });
            fourBoundaries.Add(new Boundary { Side = "left" });
            fourBoundaries.Add(new Boundary { Side = "right" });

            // Random Wall
            wall.Position.X = 100;
            wall.Position.Y = 100;

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            playerSprite = Content.Load<Texture2D>("player");
            wallSprite = Content.Load<Texture2D>("wall");
            projectileSprite = Content.Load<Texture2D>("projectile");
            wall.Texture = wallSprite;
            mainPlayer.Texture = playerSprite;
            tempProjectile.Texture = projectileSprite;

            // For the Boundaries
            boundaryTextures = new Texture2D(GraphicsDevice, 1, 1);
            boundaryTextures.SetData(new[] { Color.White });

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            boundaryTextures.Dispose();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>

        // Old Keyboard State
        KeyboardState oldKeyboard;
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Keyboard for Keypresses
            KeyboardState keyboard = Keyboard.GetState();

            // Fullscreen Key
            if (keyboard.IsKeyDown(Keys.F11) && oldKeyboard.IsKeyUp(Keys.F11))
            {
                graphics.IsFullScreen = !graphics.IsFullScreen;
                graphics.ApplyChanges();
            }
            
            // Shoot a Projectile
            if (keyboard.IsKeyDown(Keys.F) && oldKeyboard.IsKeyUp(Keys.F))
            {
                tempProjectile.Direction = mainPlayer.GetFacingDirection();
                tempProjectile.Position = new Vector2(mainPlayer.Position.X - mainPlayer.Texture.Width, mainPlayer.Position.Y - mainPlayer.Texture.Height);
                projectileList.Add(tempProjectile);
            }
            
            // Collision Handler
            if (mainPlayer.Colliding(wall))
                CheckCollision(mainPlayer);
         
            // Checks Collisions with list of Boundaries
            CheckCollisionList(mainPlayer, fourBoundaries);
            
            // Stores Keyboard so only one input is accepted per keypress
            oldKeyboard = keyboard;

            // TODO: Add your update logic here
            // Player Update
            mainPlayer.Update();

            // Bound Collision Updates
            foreach (Boundary bound in fourBoundaries)
                bound.Update(CANVAS_WIDTH, CANVAS_HEIGHT);

            // Projectile Updates
            foreach (Projectile bullet in projectileList)
                bullet.Update();

            wall.Update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DimGray);

            // Draws Sprites
            spriteBatch.Begin();
            mainPlayer.Draw(spriteBatch);
            wall.Draw(spriteBatch);

            foreach (Projectile bullet in projectileList)
                bullet.Draw(spriteBatch);

            // Draws each boundary
            foreach (Boundary bound in fourBoundaries)
                spriteBatch.Draw(boundaryTextures, bound.BoundingBox, Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        // Collision Cases
        static void CheckCollision(Player mainPlayer)
        {
            // If moving up and left, deflect them down right
            if (mainPlayer.GetMovementDirection().Equals("upleft"))
            {
                mainPlayer.Position.Y += mainPlayer.GetMovementSpeed();
                mainPlayer.Position.X += mainPlayer.GetMovementSpeed();
            }

            // If moving up and right, deflect them down left
            if (mainPlayer.GetMovementDirection().Equals("upright"))
            {
                mainPlayer.Position.Y += mainPlayer.GetMovementSpeed();
                mainPlayer.Position.X -= mainPlayer.GetMovementSpeed();
            }

            // If moving down and left, deflect them up right
            if (mainPlayer.GetMovementDirection().Equals("downleft"))
            {
                mainPlayer.Position.Y -= mainPlayer.GetMovementSpeed();
                mainPlayer.Position.X += mainPlayer.GetMovementSpeed();
            }

            // If moving down and right, deflect them up left
            if (mainPlayer.GetMovementDirection().Equals("downright"))
            {
                mainPlayer.Position.Y -= mainPlayer.GetMovementSpeed();
                mainPlayer.Position.X -= mainPlayer.GetMovementSpeed();
            }

            // If moving up, deflect them down
            if (mainPlayer.GetMovementDirection().Equals("up"))
                mainPlayer.Position.Y += mainPlayer.GetMovementSpeed();

            // If moving down, deflect them up
            if (mainPlayer.GetMovementDirection().Equals("down"))
                mainPlayer.Position.Y -= mainPlayer.GetMovementSpeed();

            // If moving right, deflect them left
            if (mainPlayer.GetMovementDirection().Equals("right"))
                mainPlayer.Position.X -= mainPlayer.GetMovementSpeed();

            // If moving left, deflect them right
            if (mainPlayer.GetMovementDirection().Equals("left"))
                mainPlayer.Position.X += mainPlayer.GetMovementSpeed();
        }

        // Collision Cases List
        static void CheckCollisionList(Player mainPlayer, List<Object2D> collisionList)
        {
            foreach (Object2D other2DObject in collisionList)
                if (mainPlayer.Colliding(other2DObject))
                    CheckCollision(mainPlayer);
        }
    }
}
