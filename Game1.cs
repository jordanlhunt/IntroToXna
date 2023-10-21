using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace IntroToXna
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        // Sprite drawing
        Texture2D helmet;
        Texture2D tome;
        Texture2D shield;
        Rectangle drawRectangleHelmet;
        Rectangle drawRectangleTome;
        Rectangle drawRectangleShield;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            // Change resolution to 800X600
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Load Content
            shield = Content.Load<Texture2D>("Graphics/shield");
            helmet = Content.Load<Texture2D>("Graphics/helmet");
            tome = Content.Load<Texture2D>("Graphics/tome");
            drawRectangleHelmet = new Rectangle(_graphics.PreferredBackBufferWidth / 4, _graphics.PreferredBackBufferHeight / 4, helmet.Width, helmet.Height);
            drawRectangleShield = new Rectangle(_graphics.PreferredBackBufferWidth / 4, _graphics.PreferredBackBufferHeight / 2, shield.Width, shield.Height);
            drawRectangleTome = new Rectangle(_graphics.PreferredBackBufferWidth / 4, _graphics.PreferredBackBufferHeight / 6, tome.Width, tome.Height);
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            // Draw Sprites
            _spriteBatch.Begin();
            _spriteBatch.Draw(helmet, drawRectangleHelmet, Color.White);
            _spriteBatch.Draw(tome, drawRectangleTome, Color.White);
            _spriteBatch.Draw(shield, drawRectangleShield, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}