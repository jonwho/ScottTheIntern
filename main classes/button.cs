using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ScottTheIntern
{
    public class button
    {

        protected Texture2D textureImage;
        public Vector2 position;
        protected int collisionOffset;
        Point currentFrame;
        Point sheetSize;
        Point frameSize;
        Rectangle btnn;
        MouseState old_mouse_state;
        KeyboardState last;
        public int wide =75 , height =84 ;
        bool yes = true;


        public button(Texture2D textureImage, Vector2 position,
        int collisionOffset, Point currentFrame, Point sheetSize, Point frameSize)
        {
            this.textureImage = textureImage;
            this.position = position;
            this.collisionOffset = collisionOffset;
            this.currentFrame = currentFrame;
            this.sheetSize = sheetSize;
            this.frameSize = frameSize;


        }

        public virtual void Update(GameTime gameTime, Rectangle clientBounds, Rectangle pointer, ref float slct)
        {
            KeyboardState ks = Keyboard.GetState();
            if (yes)
            {
                last = ks;
                yes = false;
            }
            MouseState ms = Mouse.GetState();
            btnn.Height = (int)(frameSize.Y);
            btnn.Width = (int)(frameSize.X);
            btnn.X = (int)position.X;
            btnn.Y = (int)position.Y;

            if (btnn.Intersects(pointer))
            {
                currentFrame.X = 1;
                if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter))
                    slct = 5;
            }
            else
                currentFrame.X = 0;
            if (ms.LeftButton == ButtonState.Pressed
                && old_mouse_state.LeftButton == ButtonState.Released
                && currentFrame.X == 0
                && btnn.Intersects(pointer))
            {
                currentFrame.X++;
                slct = 5;

            }
            old_mouse_state = ms;

            last = ks;
        }



        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw the sprite



            spriteBatch.Draw(textureImage,
                position,
                new Rectangle(currentFrame.X * frameSize.X,
                    currentFrame.Y * frameSize.Y,
                    frameSize.X, frameSize.Y),
                Color.White, 0, Vector2.Zero,
                1f, SpriteEffects.None, 1f);
        }
        public virtual void Drawslc(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw the sprite



            spriteBatch.Draw(textureImage, new Rectangle((int)position.X, (int)position.Y, wide, height), Color.White);
        }
    }
}
