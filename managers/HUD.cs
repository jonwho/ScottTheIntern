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
    class HUD : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Texture2D background, hpt, hud;
        SpriteFont sf;
        Rectangle hp_rec;
        int hp=0, heigth=100;



        public HUD(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            
            background = Game.Content.Load<Texture2D>("images/HUDhpf");
            hud = Game.Content.Load<Texture2D>("images/HUD.1");
            hpt = Game.Content.Load<Texture2D>("images/HUDhp");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            base.LoadContent();
        }

        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }


        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            hp = (int)Game1.scott_hp;
            heigth = hp / 2;
           // heigth--;
            spriteBatch.Begin();
            spriteBatch.Draw(hud, new Rectangle(0, 0, 600, 180), Color.White);
            spriteBatch.Draw(hpt, new Rectangle(55, 32, 36, 100), Color.White);
            spriteBatch.Draw(background,
                            new Vector2(55,32+(100-heigth)),
                            new Rectangle(0,
                                100-heigth,
                                36, 100),
                            Color.White, // This tints the sprite
                            0, // This rotates the sprite
                            new Vector2(0, 0), // This is where the origin of the sprite will be
                            1f,
                            SpriteEffects.None,
                            0.5f);
            
            spriteBatch.DrawString(sf, "HP", new Vector2(190, 10), Color.Black);
            spriteBatch.DrawString(sf, "OP", new Vector2(360, 10), Color.Black);
            spriteBatch.DrawString(sf, Game1.scott_hp + " / 200", new Vector2(155, 40), Color.Black);
            spriteBatch.DrawString(sf, Game1.scott_op + " / 100", new Vector2(320, 38), Color.Black);
            spriteBatch.DrawString(sf, "X " + Game1.coffee_amount, new Vector2(180, 100), Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
