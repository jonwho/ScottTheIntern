using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    class keyboardslct:button
    {
        KeyboardState prev;
        int rr = 73;
        int y = 80;
        int x=1;
        
        public keyboardslct(Texture2D textureImage, Vector2 position,
        int collisionOffset, Point currentFrame, Point sheetSize, Point frameSize)
            : base(textureImage, position, collisionOffset, currentFrame,
                sheetSize, frameSize) 
        { 
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds, Rectangle pointer, ref float slct)
        {
            KeyboardState curr = Keyboard.GetState();
            if ( position.Y == 278 + y * 3)
            {
                if (position.X >= 70 && position.X <= 70 + rr * 5)
                {
                    position.X = 70;
                    wide = 74*6;
                    if (curr.IsKeyDown(Keys.Right) && prev.IsKeyUp(Keys.Right))
                    {
                        position.X += rr * 6;
                        audioframe.playSound(7);
                    }
                }
                else if (position.X >= 70+rr*7 && position.X <= 70 + rr * 8)
                {
                    position.X = 70+rr*7;
                    wide = 74*2;
                    if (curr.IsKeyDown(Keys.Left) && prev.IsKeyUp(Keys.Left))
                    {
                        position.X -= 70;
                        audioframe.playSound(7);
                    }
                }
                else 
                {
                    position.X = 70 + rr * 6;
                    wide = 74;
                    if (curr.IsKeyDown(Keys.Left) && prev.IsKeyUp(Keys.Left))
                    {
                        position.X -= rr;
                        audioframe.playSound(7);
                    }
                    if (curr.IsKeyDown(Keys.Right) && prev.IsKeyUp(Keys.Right))
                    {
                        position.X += rr;
                        audioframe.playSound(7);
                    }
                    
                }

                
            }
            else if(x==1)
                wide = 74;
            if (curr.IsKeyDown(Keys.Right) && prev.IsKeyUp(Keys.Right) && position.X < 650 && position.Y != 278 + y * 3 && position.Y > 270)
            {
                position.X += rr;
                audioframe.playSound(7);
            }
            else if (curr.IsKeyDown(Keys.Left) && prev.IsKeyUp(Keys.Left) && position.X > 77 && position.Y != 278 + y * 3 && position.Y > 270)
            {
                position.X -= rr;
                audioframe.playSound(7);
            }
            else if (curr.IsKeyDown(Keys.Up) && prev.IsKeyUp(Keys.Up) && position.Y > 280)
            {
                position.Y -= y;
                audioframe.playSound(7);
            }
            else if (curr.IsKeyDown(Keys.Up) && prev.IsKeyUp(Keys.Up) && position.Y == 278)
            {
                position.Y = 248;
                position.X = 70;
                wide = 121;
                height=30;
                x = 0;
                audioframe.playSound(7);
            }
            else if (curr.IsKeyDown(Keys.Enter) && prev.IsKeyUp(Keys.Enter) && position.Y == 248)
            {
                Game1.screen_selector = 0;
                position.Y = 278;
                position.X = 70;
                wide = 74;
                height = 84;
                x = 1;
                
            }
            else if (curr.IsKeyDown(Keys.Down) && prev.IsKeyUp(Keys.Down) && position.Y == 248)
            {
                position.Y = 278;
                position.X = 70;
                wide = 74;
                height = 84;
                x = 1;
                audioframe.playSound(7);
            }
            else if (curr.IsKeyDown(Keys.Down) && prev.IsKeyUp(Keys.Down) && position.Y < 500 && position.Y > 270)
            {
                position.Y += y;
                audioframe.playSound(7);
            }

            else if (curr.IsKeyDown(Keys.Left) && prev.IsKeyUp(Keys.Left) && position.X == 70 + rr * 6 && position.Y == 278 + y * 3 && position.Y > 270)
            {
                position.X -= rr * 6;
                wide = 74;
                audioframe.playSound(7);
            }

            else if (curr.IsKeyDown(Keys.Space) && prev.IsKeyUp(Keys.Space))
            {
                if (keyboardscreen.x == 0)
                    keyboardscreen.name = keyboardscreen.name.Substring(0, 0);
                if (position.X == 70 && position.Y == 278)
                    keyboardscreen.name += "A";
                else if (position.X == 70 + rr && position.Y == 278)
                    keyboardscreen.name += "B";
                else if (position.X == 70 + rr * 2 && position.Y == 278)
                    keyboardscreen.name += "C";
                else if (position.X == 70 + rr * 3 && position.Y == 278)
                    keyboardscreen.name += "D";
                else if (position.X == 70 + rr * 4 && position.Y == 278)
                    keyboardscreen.name += "E";
                else if (position.X == 70 + rr * 5 && position.Y == 278)
                    keyboardscreen.name += "F";
                else if (position.X == 70 + rr * 6 && position.Y == 278)
                    keyboardscreen.name += "G";
                else if (position.X == 70 + rr * 7 && position.Y == 278)
                    keyboardscreen.name += "H";
                else if (position.X == 70 + rr * 8 && position.Y == 278)
                    keyboardscreen.name += "I";
                else if (position.X == 70 && position.Y == 278 + y)
                    keyboardscreen.name += "J";
                else if (position.X == 70 + rr && position.Y == 278 + y)
                    keyboardscreen.name += "K";
                else if (position.X == 70 + rr * 2 && position.Y == 278 + y)
                    keyboardscreen.name += "L";
                else if (position.X == 70 + rr * 3 && position.Y == 278 + y)
                    keyboardscreen.name += "M";
                else if (position.X == 70 + rr * 4 && position.Y == 278 + y)
                    keyboardscreen.name += "N";
                else if (position.X == 70 + rr * 5 && position.Y == 278 + y)
                    keyboardscreen.name += "O";
                else if (position.X == 70 + rr * 6 && position.Y == 278 + y)
                    keyboardscreen.name += "P";
                else if (position.X == 70 + rr * 7 && position.Y == 278 + y)
                    keyboardscreen.name += "Q";
                else if (position.X == 70 + rr * 8 && position.Y == 278 + y)
                    keyboardscreen.name += "R";
                else if (position.X == 70 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "S";
                else if (position.X == 70 + rr && position.Y == 278 + y * 2)
                    keyboardscreen.name += "T";
                else if (position.X == 70 + rr * 2 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "U";
                else if (position.X == 70 + rr * 3 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "V";
                else if (position.X == 70 + rr * 4 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "W";
                else if (position.X == 70 + rr * 5 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "X";
                else if (position.X == 70 + rr * 6 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "Y";
                else if (position.X == 70 + rr * 7 && position.Y == 278 + y * 2)
                    keyboardscreen.name += "Z";
                else if (position.X == 70 + rr * 8 && position.Y == 278 + y * 2)
                    keyboardscreen.name += ".";
                else if (position.X == 70 && position.Y == 278 + y * 3)
                    keyboardscreen.name += " ";
                else if (position.X == 70 + rr * 6 && position.Y == 278 + y * 3)
                    keyboardscreen.name += "_";
                else if (position.X == 70 + rr * 7 && position.Y == 278 + y * 3 && keyboardscreen.name.Length > 0)
                    keyboardscreen.name = keyboardscreen.name.Substring(0, keyboardscreen.name.Length - 1);

                keyboardscreen.x = 1;
            }
            prev = curr;


            base.Update(gameTime, clientBounds,pointer,ref slct);
        }
       
    }
}
