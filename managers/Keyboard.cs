using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace ScottTheIntern
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class keyboardscreen : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        //Put the variables for this stage of the game here
        Texture2D keyboard_screen;
        keyboardslct selec;
        bool go_to_next_screen = false;
        Rectangle rect;
        float s = 5;
        public static int x = 0;
        SpriteFont sf;
        public static string name = "Enter your name";
        string[] names = null;
        public decimal des = 0;
        button back;
        KeyboardState last;
        bool yes = true;

        public keyboardscreen(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {


            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            selec = new keyboardslct(Game.Content.Load<Texture2D>("images/letterslct"),
                      new Vector2(70, 278), 0, new Point(0, 0), new Point(1, 1), new Point(77, 86));
            keyboard_screen = Game.Content.Load<Texture2D>("images/keyboard");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            names = save_game.continuegame(ref des);
            back = new button(Game.Content.Load<Texture2D>("images/BuTTonSet"),
                      new Vector2(70, 248), 0, new Point(0, 2), new Point(1, 1), new Point(121, 30));
            name = "Enter your name";
            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();
            if (yes)
            {
                last = kb;
                yes = false;
            }
            selec.Update(gameTime, Game.Window.ClientBounds, rect, ref s);
            if (kb.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter) && Game1.screen_selector != 0)
            {
                Game1.screen_selector = 3;
                if (name != "Enter your name")
                    Game1.username = name;
                else
                    Game1.username = "No Name";
            }
            last = kb;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            back.Draw(gameTime, spriteBatch);
            spriteBatch.Draw(keyboard_screen, new Vector2(70, 278), Color.White);
            
            spriteBatch.DrawString(sf
                , "Press the spacebar to select and the arrows to move.\nEnter when you are done\n",
                new Vector2(0, 0), Color.Red);
            //if(x==1)
            spriteBatch.DrawString(sf, name, new Vector2(0, 60), Color.White);
            selec.Drawslc(gameTime, spriteBatch);




            spriteBatch.End();

            base.Draw(gameTime);
        }

        public virtual void Load()
        {

            name = null;


            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            x = 0;

            keyboard_screen = Game.Content.Load<Texture2D>("images/keyboard");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");

            back = new button(Game.Content.Load<Texture2D>("images/BuTTonSet"),
                      new Vector2(70, 248), 0, new Point(0, 2), new Point(1, 1), new Point(121, 30));
            name = "Enter your name";


        }
    }
}