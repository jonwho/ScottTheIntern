using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    class pointer : Sprite
    {
        KeyboardState prev;
         public pointer(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) { 
         }

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            if (collision == 0)
            {
                MouseState ms = Mouse.GetState();
                if (ms.X < (clientBounds.Width - frameSize.X) && ms.X > 0)
                    position.X = ms.X;
                if (ms.Y > 0 && ms.Y < clientBounds.Height - frameSize.Y)
                    position.Y = ms.Y;
            }
            else
            {
                KeyboardState curr = Keyboard.GetState();
                if (curr.IsKeyDown(Keys.Down) && prev.IsKeyUp(Keys.Down))
                {
                    position.Y =417;
                    audioframe.playSound(7);
                }
                if (curr.IsKeyDown(Keys.Up) && prev.IsKeyUp(Keys.Up))
                {
                    position.Y =335;
                    audioframe.playSound(7);
                }
                prev = curr;
            }

            
            base.Update(gameTime, clientBounds, collision);
        }
    }
}
