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
   
    public class Title : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        //Put the variables for this stage of the game here
       Texture2D background;
        button[] btns = new button[4];
        Rectangle pointer;
        pointer poin;
        float[] selected_btn = {1,1,1,1};
        bool go_to_next_screen = false,go_to_continue=false;
        SpriteFont sf;
       
        
        public Title(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            background = Game.Content.Load<Texture2D>("images/Title Banner");
            btns[0] = new button(Game.Content.Load<Texture2D>("images/ButtonSet"),
                      new Vector2(278, 378), 0, new Point(0, 0), new Point(1, 2), new Point(121, 30));
            btns[1] = new button(Game.Content.Load<Texture2D>("images/ButtonSet"),
                     new Vector2(278, 460), 0, new Point(0, 1), new Point(1, 2), new Point(121, 30));
            
            poin = new pointer(Game.Content.Load<Texture2D>("images/scott2"), new Vector2(398,335), new Point(100, 100),
            0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
            0);
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            audioframe.LoadContent(Game.Content);
            audioframe.playsong();

            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {    MouseState ms = Mouse.GetState();        
            //if something happened
            pointer=new Rectangle((int)poin.position.X,(int)poin.position.Y,100,100);
            
            btns[0].Update(gameTime,Game.Window.ClientBounds,pointer,ref selected_btn[0]);
            btns[1].Update(gameTime, Game.Window.ClientBounds, pointer, ref selected_btn[1]);
            poin.Update(gameTime, Game.Window.ClientBounds, 1);
            if (selected_btn[0] == 5)
            {
                poin.position.Y=335;
                Game1.screen_selector = 1;//go_to_next_screen = true;
                selected_btn[0] = 0;
            }
            if (selected_btn[1] == 5)
            {
                
                Game1.screen_selector = 2;//go_to_continue = true;
                selected_btn[1] = 0;
                poin.position.Y = 335;
            }

            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            btns[0].Draw(gameTime, spriteBatch);
            btns[1].Draw(gameTime, spriteBatch);
            poin.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(sf
                , "Press enter to select\n",
                new Vector2(0, 0), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public bool isDone()
        {
            return go_to_next_screen;
        }
        public bool isDonegotocont()
        {
            return go_to_continue;
        }
    }
}