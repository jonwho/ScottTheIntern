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
    public class Lvl1 : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        public static Scott scott;
        SpriteFont sf;
        Texture2D message;
        public static int[] collision = { 0, 0, 0, 0 };
        public static Vector2 position = new Vector2(450, 550);
        KeyboardState last;
        public static int[] itemsstate = new int[500];
        public static int backx = 0, animate = 0, mapno=1;
        public static string messages = "";

        public Lvl1(Game game)
            : base(game)
        {
            
        }

       
        public override void Initialize()
        {
        
                base.Initialize();
        }

        public static void loadGame()
        {

        }
        protected override void LoadContent()
        {
            message = Game.Content.Load<Texture2D>("images/messages");
            scott = new Scott(Game.Content.Load<Texture2D>("images/walkinghectoredit"), position, new Point(18, 49),
            0, new Point(0, 0), new Point(8, 4), new Vector2(2, 2),
            50);
            MapLoader.LoadContent(Game.Content);
            scott.position = new Vector2(600, 540);
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            Item.loaditems(Game.Content);
            sf = Game.Content.Load<SpriteFont>("Font/Descrip");


            base.LoadContent();
        }

        
        public override void Update(GameTime gameTime)
        {
            MapLoader.Update(gameTime, Game.Window.ClientBounds, mapno);
            
            if (Game1.load_game > 0)
            {
                scott.position = position;
                for (int x = 0; x < 6; x++)
                {
                    Map1.items[x].currentFrame = new Point(itemsstate[x],0);
                }

                Game1.load_game = -1;
            }
            position = scott.position;
           
            
            
            scott.Update(gameTime, Game.Window.ClientBounds, animate);

            collision[0] = 0;
            collision[1] = 0;
            collision[2] = 0;

            collision[3] = 0;
            
            

            KeyboardState kb = Keyboard.GetState();

           
            if (kb.IsKeyDown(Keys.Escape) && last.IsKeyUp(Keys.Escape))
            {
                Pause_menu.yes = true;
                Pause_menu.select.position = new Vector2(5,10);
                Game1.screen_selector = 5;
            
            }
            last = kb;
            

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
           
            spriteBatch.Begin();
            MapLoader.Draw(gameTime, spriteBatch, mapno);
            scott.Draw(gameTime, spriteBatch);
            if(mapno==1)
            Map1.Draw2(gameTime, spriteBatch);
            spriteBatch.Draw(message, new Vector2(0,510), Color.White);
            spriteBatch.DrawString(sf
                    , messages,
                    new Vector2(10, 520), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public virtual void Load()
        {


            scott.position = new Vector2(600, 540);
            scott.currentFrame.Y = 0;

            for (int x = 0; x < 6; x++)
            {
               
                Map1.items[x].currentFrame.X = 0;
            }
            Map1.items[Map1.items.Count - 1].currentFrame.X = 0;
            while(Map1.internlist.Count>0)
            {
                Map1.internlist.RemoveAt(Map1.internlist.Count-1);
                InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count-1);
                
            }
            backx = 0;
            for (int x = 0; x < Map1.intern_number; x++)
            {
                Map1.internlist.Add(new NPC(Game.Content.Load<Texture2D>("images/enemy overworld2"), new Vector2(200 + (50 * x), 530), new Point(18, 50),
                                0, new Point(0, 0), new Point(1, 1), new Vector2(1, 1), 0));


               InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));



            }
            
            
        }
    }
}