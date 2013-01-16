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
    public class Continue : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        //Put the variables for this stage of the game here
        button trim;
        button back;
        continueslec[] namesbt = null;
        string[] names;
        decimal snumber;
        bool yes = true;
        SpriteFont sf;
        Rectangle select;
        int wide;
        public static int name_sele = 0;
        float z;
        int nameyp = 1, namex = 350;
        KeyboardState last;
        Vector2 size;
        bool resize = true;

        public Continue(Game game)
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
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            trim = new button(Game.Content.Load<Texture2D>("images/butnselec"),
                      new Vector2(334, 52), 0, new Point(0, 0), new Point(1, 1), new Point(121, 30));
            back = new button(Game.Content.Load<Texture2D>("images/ButtonSet"),
                      new Vector2(600, 52), 0, new Point(0, 2), new Point(1, 1), new Point(121, 30));

            names = save_game.continuegame(ref snumber);
            namesbt = new continueslec[(int)snumber];
            for (int x = 0; x < snumber; x++)
            {
                namesbt[x] = new continueslec(Game.Content.Load<Texture2D>("images/button"),
                    new Vector2(350, (50 * x) + 50), new Point(121, 30),
            0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
            0);
            }
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            trim.position.X = 375 - sf.MeasureString(names[0]).X / 2;

            base.Initialize();
        }

        protected override void LoadContent()
        {

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (yes)
            {
                last = ks;
                yes = false;
            }

            trim.Update(gameTime, Game.Window.ClientBounds, select, ref z);
            for (int x = 0; x < snumber; x++)
            {
                namesbt[x].Update(gameTime, Game.Window.ClientBounds, x);
            }

            if (ks.IsKeyDown(Keys.Up) && last.IsKeyUp(Keys.Up) && trim.position.X != 600 && trim.position.X != 600 && nameyp < 1)
            {
                nameyp++;

            }
            else if (ks.IsKeyDown(Keys.Down) && last.IsKeyUp(Keys.Down) && (nameyp * -1) < (snumber - 2))
                nameyp--;
            else if ((ks.IsKeyDown(Keys.Right) && last.IsKeyUp(Keys.Right) && snumber > 0) || snumber == 0)
            {
                resize = false;
                trim.wide = 121;
                trim.position.X = 600;
                
            }
            else if (ks.IsKeyDown(Keys.Left) && last.IsKeyUp(Keys.Left) && snumber > 0)
                resize = true;//trim.position.X = 334;
            if (snumber == 0)
                namex = 200;
            
            if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter) && trim.position.X == 600)
            {
                Game1.screen_selector = 0;
                if (snumber > 0)
                    trim.position.X = 334;

            }
            else if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter) && trim.position.X != 600)
            {
                save_game.loadgame((nameyp - 2) * -1);
                Game1.load_game = 1;
                Game1.screen_selector = 3;
                Game1.savedno = (nameyp - 2) * -1;
            }
            last = ks;



            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            spriteBatch.Begin();
            back.Draw(gameTime, spriteBatch);

            //trim.Draw(gameTime, spriteBatch);

            // spriteBatch.Draw(ninja_screen, new Rectangle(0, 0, 800, 600), Color.White);
            for (int x = 0; x < snumber; x++)
            {
                
                namex = 375-(int)sf.MeasureString(names[x]).X/2;
                spriteBatch.DrawString(sf, names[x], new Vector2(namex, (50 * x) + 50 * nameyp), Color.Black);
                if ((50 * x) + 50 * nameyp==50&&resize == true)
                {
                    size = sf.MeasureString(names[x]);
                    trim.position.X= 375-sf.MeasureString(names[x]).X/2;
                    trim.wide = (int)size.X;
                }
                


            }
            trim.height = 30;
            
            trim.Drawslc(gameTime, spriteBatch);

            if (snumber == 0)
                spriteBatch.DrawString(sf, names[0], new Vector2(namex, 50 + 0), Color.Black);// test
            spriteBatch.End();


            base.Draw(gameTime);
        }
        public virtual void Load()
        {
            names = null;
            namesbt = null;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            trim = new button(Game.Content.Load<Texture2D>("images/butnselec"),
                      new Vector2(334, 52), 0, new Point(0, 0), new Point(1, 1), new Point(121, 30));
            back = new button(Game.Content.Load<Texture2D>("images/ButtonSet"),
                      new Vector2(600, 52), 0, new Point(0, 2), new Point(1, 1), new Point(121, 30));

            names = save_game.continuegame(ref snumber);
            namesbt = new continueslec[(int)snumber];
            for (int x = 0; x < snumber; x++)
            {
                namesbt[x] = new continueslec(Game.Content.Load<Texture2D>("images/button"),
                    new Vector2(350, (50 * x) + 50), new Point(121, 30),
            0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
            0);
            }
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");


        }


    }
}