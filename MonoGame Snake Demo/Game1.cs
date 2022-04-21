using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_Snake_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // An empty texture to draw plain colors
        private Texture2D blankTexture;

        // Keep track of where the player is
        // vector to keep position as a float and rect to give the draw method
        private Vector2 playerPos;
        private Rectangle playerRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Start the player at 30x30 at 100,100
            playerPos = new Vector2(100, 100);
            playerRect = new Rectangle(100, 100, 30, 30);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            // Make an empty texture that we can just tint to draw basic colors
            blankTexture = new Texture2D(GraphicsDevice, 1, 1);
            blankTexture.SetData(new Color[] { Color.White });
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
            GraphicsDevice.Clear(Color.Black);

            // All the drawing must be within the begin and end calls of the spritebatch
            _spriteBatch.Begin();

            // Show the player as a blank square at the rectangle made earlier colored green
            _spriteBatch.Draw(blankTexture, playerRect, Color.White);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
