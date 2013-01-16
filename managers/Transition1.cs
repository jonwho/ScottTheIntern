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
    class Transition1 : Microsoft.Xna.Framework.DrawableGameComponent
    {
        
        
        int timer = 0;


        public Transition1(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
            
        }

        protected override void LoadContent()
        {

        }
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }


        public override void Update(GameTime gameTime)
        {
            timer += gameTime.ElapsedGameTime.Milliseconds;
            if (timer >= 1000)
            {
                if (Game1.boss_npc == true)
                    audioframe.playSound(9);
                Game1.screen_selector = 4;
                timer = 0;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            if(timer % 200 == 0)
                GraphicsDevice.Clear(Color.Red);
            else
                GraphicsDevice.Clear(Color.Black);
            

            
            base.Draw(gameTime);
        }
    }
}
