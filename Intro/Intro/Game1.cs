using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D Image;
        Vector2 Position;
        Color Tint;

        //make a sprite class
        //make class for each object (paddle,brick,ball etc etc)
        //make game.
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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

        public Vector2 speed;
            protected override void LoadContent()
        {
            float defaultSpeed = 1;
             speed = new Vector2(defaultSpeed, defaultSpeed);
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Image = Content.Load<Texture2D>("shadowMorty");
            Position = new Vector2(100, 100);
            Tint = Color.White;
           
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provide
        /// s a snapshot of timing values.</param>
        public void giveSpeed()
        {
            Position.X += speed.X;

            Position.Y += speed.Y;

        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Position.X += speed.X;

            Position.Y += speed.Y;
            //clientsize = graphicsDevice.viewPort. <----------------
            if (Position.X < 0|| Position.X + Image.Width > GraphicsDevice.Viewport.Width)
            {
                speed.X *= -1;

            }
            if(Position.Y < 0 || Position.Y+ Image.Height > GraphicsDevice.Viewport.Height)
            {
                speed.Y *= -1;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            spriteBatch.Draw(Image, Position, Tint);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
