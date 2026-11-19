using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_2___Scaling_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D circleTexure, rectangleTexture;

        SpriteFont TextFont;

        Rectangle rec1, rec2;
        Rectangle circleRect;
        Rectangle topRec, halfRec, bottomRec;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            rec1 = new Rectangle(50, 50, 100, 35);
            rec2 = new Rectangle(50, 100, 50, 40);
            circleRect = new Rectangle(25, 70, 40, 80);

            topRec = new Rectangle(0, 0, window.Width, 15);
            halfRec = new Rectangle(0, 200, window.Width / 2, 20);
            bottomRec = new Rectangle(0, window.Height -20, window.Width, 20);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexure = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            TextFont = Content.Load<SpriteFont>("Textfont");
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

            // TODO: Add your drawing code here
            //_spriteBatch.Begin();

            //_spriteBatch.Draw(rectangleTexture, rec1, Color.Red);
            //_spriteBatch.Draw(rectangleTexture, rec2, Color.Yellow);
            //_spriteBatch.Draw(circleTexure, circleRect, Color.Purple);

            //_spriteBatch.Draw(rectangleTexture, topRec, Color.Purple);
            //_spriteBatch.Draw(rectangleTexture, halfRec, Color.Purple);
            //_spriteBatch.Draw(rectangleTexture, bottomRec, Color.Purple);
            //_spriteBatch.DrawString(TextFont, "Mr. Aldworth", new Vector2(100, 100), Color.Black);

            //Assignment
            _spriteBatch.Draw(circleTexure, circleRect, Color.Purple);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
