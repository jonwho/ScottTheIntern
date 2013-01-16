using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    class continueslec : Sprite
    {
        KeyboardState prev;
         public continueslec(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) { 
         }

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            
                KeyboardState curr = Keyboard.GetState();
                if (curr.IsKeyDown(Keys.Down) && prev.IsKeyUp(Keys.Down))
                {
                    position.Y =342;
                }
                if (curr.IsKeyDown(Keys.Up) && prev.IsKeyUp(Keys.Up))
                {
                    position.Y =260;
                }
                prev = curr;
            if(position.Y<=55)   
            Continue.name_sele = collision;

            
            base.Update(gameTime, clientBounds, collision);
        }
        public virtual void Drawslc(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw the sprite



            spriteBatch.Draw(textureImage, new Rectangle((int)position.X, (int)position.Y, 150, 35), Color.White);
        }
    }
}
