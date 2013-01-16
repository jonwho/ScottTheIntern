using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Generic Sprite class.
// Main purpose should be only to have virtual methods that we will
// later on override in subclasses. And also contain all generic
// info that each sprite will need, such as HP when the battles go down.
namespace ScottTheIntern
{
    // Made abstract because we will most likely not instantiate this class whatsoever.
    // Instantiations should be made for its subclasses only.
    public class Sprite
    {
        // Variables within Sprite
        public Texture2D textureImage; // Sprite or sprite sheet of image being drawn
        public Vector2 position; // Position at which to draw sprite
        public Point frameSize; // Size of each individual frame in sprite sheet
        public int collisionOffset; // Offset used to modify frame-size rectangle for collision checks against this sprite
        public Point currentFrame; // Index of current frame in sprite sheet
        Point sheetSize; // Number of columns/rows in sprite sheet
        int timeSinceLastFrame = 0; // Number of milliseconds since last frame was drawn
        int millisecondsPerFrame; // Number of milliseconds to wait between frame changes
        public Vector2 speed; // Speed at which sprite will move in both X and Y directions
        const int defaultMillisecondsPerFrame = 16;
        public int[] colli = { 0, 0, 0, 0 };
        public int col = 0;
        //float size;
        // Sprite constructor
        public Sprite(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
        {
            this.textureImage = textureImage;
            this.position = position;
            this.frameSize = frameSize;
            this.collisionOffset = collisionOffset;
            this.currentFrame = currentFrame;
            this.sheetSize = sheetSize;
            this.speed = speed;
            this.millisecondsPerFrame = millisecondsPerFrame;
        }

        public virtual void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            //size=clientBounds.Width / 800;
            /**
             * Not all sprites will be animated but even so this
             * animation code won't cause compilation errors even if sprite
             * contains no animations
             **/

            // Update animation frame
            if(collision==1||col==1)
            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (timeSinceLastFrame > millisecondsPerFrame)
            {
                timeSinceLastFrame = 0;
                ++currentFrame.X;
                if (currentFrame.X >= sheetSize.X)
                {
                    currentFrame.X = 0;
                   // ++currentFrame.Y;
                   // if (currentFrame.Y >= sheetSize.Y)
                     //   currentFrame.Y = 0;
                }
            }
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            /*
             * For the Draw mehod I want to create variables for each
             * so that we can create abstract getters in this class
             * that must be implemented by subclasses. That way we can
             * keep our code more OO style and it'll be easier for us to 
             * debug later on. For now I left some as constants.
             */

            // Draw the sprite
            spriteBatch.Draw(textureImage,
                            position,
                            new Rectangle(currentFrame.X * frameSize.X,
                                currentFrame.Y * frameSize.Y,
                                frameSize.X, frameSize.Y),
                            Color.White, // This tints the sprite
                            0, // This rotates the sprite
                            new Vector2(0, 0), // This is where the origin of the sprite will be
                            1f,
                            SpriteEffects.None,
                            0f);
        }
    }
}
