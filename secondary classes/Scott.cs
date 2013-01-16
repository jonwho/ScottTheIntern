using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    // Scott is a subclass of Sprite
    public  class Scott : Sprite
    {
        public static bool right = false,left=false;
        public Rectangle scottr;
        
        // Scott constructor that must inherently call super class constructor.
        public Scott(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) 
        { 
        
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            scottr = new Rectangle((int)position.X, (int)position.Y, frameSize.X, frameSize.Y);
            KeyboardState controll = Keyboard.GetState();
            
               
                    if (controll.IsKeyDown(Keys.Left) )
                    {
                         if(Lvl1.collision[0]==0)
                         {
                            if ((position.X <= 58 && Lvl1.backx < 0&&Lvl1.mapno==1)||(position.X <= 58 &&Lvl1.mapno>1))
                            {
                                Lvl1.backx += (int)speed.X;
                                left=true;
                                Lvl1.scott.currentFrame.Y = 2;
                                Lvl1.animate = 1;
                                
                            }

                            else if (position.X > 7)
                            {
                                position.X -= speed.X;
                                left = false;
                                right = false;
                                Lvl1.scott.currentFrame.Y = 2;
                                Lvl1.animate = 1;
                            }
                         }
                         else
                         {
                             Lvl1.animate = 0;
                             right = false;
                             left = false;
                         }
                    }
                
                    else if (controll.IsKeyDown(Keys.Right) )
                    {
                        if (Lvl1.collision[1] == 0)
                        {
                            if (position.X > clientBounds.Width - 68 && Lvl1.backx > -1000)
                            {
                                Lvl1.backx -= (int)speed.X;
                                right = true;
                                Lvl1.scott.currentFrame.Y = 3;
                                Lvl1.animate = 1;

                            }
                            else if (position.X < clientBounds.Width - (frameSize.X + 7))
                            {
                                position.X += speed.X;
                                right = false;
                                left = false;
                                Lvl1.scott.currentFrame.Y = 3;
                                Lvl1.animate = 1;
                            }
                        }
                        else
                        {
                            Lvl1.animate = 0;
                            right = false;
                            left = false;
                        }
                    }

                    else if (controll.IsKeyDown(Keys.Up) && position.Y > 0)
                    {
                        if (Lvl1.collision[2] == 0)
                        {
                            position.Y -= speed.Y;
                            Lvl1.scott.currentFrame.Y = 1;
                            Lvl1.animate = 1;
                        }
                        else
                            Lvl1.animate = 0;
                        left = false;
                        right = false;

                    }

                    else if (controll.IsKeyDown(Keys.Down) && position.Y < clientBounds.Height - 57)
                    {
                        if (Lvl1.collision[3] == 0)
                        {
                            position.Y += speed.Y;
                            Lvl1.scott.currentFrame.Y = 0;
                            Lvl1.animate = 1;
                        }
                        else
                            Lvl1.animate = 0;
                        left = false;
                        right = false;
                        
                    }

                    else
                    {
                        left = false;
                        right = false;
                        Lvl1.animate = 0;
                        Lvl1.scott.currentFrame.X = 0;

                    }
            
            base.Update(gameTime, clientBounds,collision);
        }

        public Vector2 getPos()
        {
            return position;
        }
    }
}
