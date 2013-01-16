using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScottTheIntern
{
    class Background: Sprite
    {
        public Background(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) 
        {
 
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            
            base.Update(gameTime, clientBounds, collision);
        }
    }
}
