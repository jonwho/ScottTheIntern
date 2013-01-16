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
    
    public class Pause_menu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        SpriteFont sf;
        Vector2 size;
        Texture2D background, menu;
        public static button select;
        string[] options={"Scott","Items","Save","Main menu","Exit Game"};
        KeyboardState last;
        public static bool yes = true;
        bool drawmessage = false;
        int time;
        bool go_to_next_screen = false;

        public Pause_menu(Game game)
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
            // TODO: Add your initialization code here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            select = new button(Game.Content.Load<Texture2D>("images/menu select"),
                      new Vector2(5, 10), 0, new Point(0, 0), new Point(1, 1), new Point(121, 30));
            background = Game.Content.Load<Texture2D>("images/pauseback");
            menu = Game.Content.Load<Texture2D>("images/pause menu");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            select.height = 40;
            select.wide = 400;
            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (yes)
            {
                last = ks;
                yes = false;
            }
            if (ks.IsKeyDown(Keys.Up) && last.IsKeyUp(Keys.Up) && select.position.Y > 10)
            {
                select.position.Y -= 50;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Down) && last.IsKeyUp(Keys.Down) && select.position.Y < 200)
            {
                select.position.Y += 50;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Escape) && last.IsKeyUp(Keys.Escape))
                Game1.screen_selector = 3;
            else if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter))
            {

                if (select.position.Y == 10)
                {
                    Submenu.menutype = 0;

                }

                else if (select.position.Y == 60)
                {
                    Submenu.select.position = new Vector2(230, 100);
                    Submenu.menutype = 1;
                }

                else if (select.position.Y == 110)
                {
                    save_game.save(Game1.username, Game1.savedno);
                    Submenu.menutype = 2;

                }
                else if (select.position.Y == 160)
                {
                    Submenu.select.position = new Vector2(353, 110);
                    Submenu.menutype = 5;

                }
                else if (select.position.Y == 210)
                {
                    Submenu.select.position = new Vector2(353, 110);
                    Submenu.menutype = 5;


                }
                Submenu.yes = true;
                Game1.screen_selector = 7;
            }
            last = ks;
            

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.Draw(menu, new Rectangle(0, 0, 218, 300), Color.White);
            if (drawmessage == true)
            {
                spriteBatch.Draw(menu, new Rectangle(218, 75, 200, 100), Color.White);
                spriteBatch.DrawString(sf
                    , "Save \nCompleted",
                    new Vector2(230, 80), Color.Black);
               
                time+=gameTime.ElapsedGameTime.Milliseconds;
                if(time>500)
                {
                drawmessage = false;
                    time=0;
                }
            }
            for (int x = 0; x < 5; x++)
            {
                spriteBatch.DrawString(sf
                    , options[x],
                    new Vector2(10, 10+(50*x)), Color.Black);
                if (select.position.Y == (10+(50*x)))
                {
                    size = sf.MeasureString(options[x]);
                    select.wide = (int)size.X+15;
                }
                
            }
            
            select.Drawslc(gameTime, spriteBatch);
            spriteBatch.End();


            base.Draw(gameTime);
        }

        public bool isDone()
        {
            return go_to_next_screen;
        }
    }
}