using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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
        Ball ball;
        Paddle paddle;
        Brick brick;
        List<Brick> bricks;
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
            bricks = new List<Brick>();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Image = Content.Load<Texture2D>("shadowMorty");
            Position = new Vector2(100, 100);
            Tint = Color.White;
            ball = new Ball(Content.Load<Texture2D>("Ball"), new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 3), Color.White);
            paddle = new Paddle(Content.Load<Texture2D>("Paddle"), new Vector2(ball.position.X, GraphicsDevice.Viewport.Height - 20), Color.White);
            int spaceInBetween = 0;
            for(int i =0; i < 48;i++)
            {
                if (i == 16 || i == 32)
                {
                    spaceInBetween = 0;
                }
                if (i < 16)
                { 
                bricks.Add(new Brick(Content.Load<Texture2D>("Bricks"), new Vector2(spaceInBetween,0 ), Color.White));
                    
                }
              
                else if (i > 16 && i < 32)
                {
                    bricks.Add(new Brick(Content.Load<Texture2D>("Bricks2"), new Vector2(spaceInBetween, 30), Color.White));
                }
                else if (i >31 && i < 48)
                {
                    bricks.Add(new Brick(Content.Load<Texture2D>("Bricks3"), new Vector2(spaceInBetween, 60), Color.White));
                }
                spaceInBetween += 50;
            }
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
        
        
        protected override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (ball.hitbox.Intersects(paddle.hitbox))
            {
                ball.flipSpeed();
            }
          
            paddle.checkButtonPress(ks, GraphicsDevice.Viewport);
            ball.move(GraphicsDevice.Viewport);
            //clientsize = graphicsDevice.viewPort. <----------------
            
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
            paddle.Draw(spriteBatch);
            ball.Draw(spriteBatch);
            for(int i =0; i < bricks.Count;i++)
            {
                bricks[i].Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
