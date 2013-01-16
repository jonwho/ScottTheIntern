using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    public class InteractiveItems : Sprite
    {
        Rectangle item;
        KeyboardState last;
        public static List<Rectangle> interns = new List<Rectangle>();
        
        float xpos;
        bool getp = true, rect = true;
        int c = 1;

         public InteractiveItems(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) { }

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            if(getp)
            {
                xpos=position.X;
                getp =false;
            }
            for (int x = 0; x < interns.Count; x++)
            {
                
                if(Lvl1.mapno==1)
                    interns[x] = Map1.internlist[x].npc;
                else if(Lvl1.mapno==2)
                    interns[x] = Map.internlist[x].npc;
                
            }
            
            int y=0;
            int yy=interns.Count;
            foreach (Rectangle intern in interns)
                {
                    if (y < interns.Count&&Lvl1.mapno==1)
                    {
                        Functions.collision(item, intern, new Vector2(1, 1), Map1.internlist[y].colli);
                    }
                    else if (y < interns.Count&&Lvl1.mapno==2)
                    {
                        Functions.collision(item, intern, new Vector2(1, 1), Map.internlist[y].colli);
                    }
                    y++;
                }
            position.X = xpos + (float)Lvl1.backx;
            KeyboardState ks = Keyboard.GetState();
            item = new Rectangle((int)position.X, (int)position.Y, (int)frameSize.X, (int)textureImage.Height);
            if(collision!=3)
            
                
                if (Functions.collision(item, Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision))
            {

                
                if (ks.IsKeyDown(Keys.Space) && last.IsKeyUp(Keys.Space) && collision == 5 && currentFrame.X == 0 && speed.X == 1)
                {
                    if (Map1.internlist.Count > 0)
                    {
                        Lvl1.messages="You opened the door.";
                        while (interns.Count > 0)
                        {
                            interns.RemoveAt(interns.Count - 1);
                        }
                        for (int x = 0; x < Map.internlist.Count; x++)
                        {
                            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
                        }
                        Lvl1.scott.position.Y = 530;
                        Lvl1.scott.position.X = 420;
                        
                        Lvl1.mapno = 2;
                        audioframe.office_theme_instance.Play();
                        audioframe.song2.Stop();
                        Lvl1.backx = 0;
                    }
                }
                else if (ks.IsKeyDown(Keys.Space) && last.IsKeyUp(Keys.Space) && collision == 5 && currentFrame.X == 0)
                {
                    Random rand = new Random();
                    currentFrame.X = 1;
                    int ite = rand.Next(1, 6);
                    if (ite > 0 && ite < 6 && ite != 4)
                        Inventory.inventory(ite);
                    else if (ite == 4)
                    {
                        ite = rand.Next(3, 5);
                        if (ite == 3)
                        {
                            ite = 0;
                            Inventory.inventory(ite);
                        }
                        else if (ite == 4)
                            Inventory.inventory(ite);

                    }
                    if (ite == 0)
                        Lvl1.messages = "You found NOTHING better luck next time";
                    else if (ite == 1)
                        Lvl1.messages = "You found a Zero Energy can";
                    else if (ite == 2)
                        Lvl1.messages = "You found a Strength Tie";
                    else if (ite == 3)
                        Lvl1.messages = "You found a Defense Tie";
                    else if (ite == 4)
                        Lvl1.messages = "You found a Bluetooth";
                    else if (ite == 5)
                        Lvl1.messages = "You found a Office Tie";

                    audioframe.playSound(1);
                    //when item is not found
                    //audioframe.playSound(4);


                }
                
            }
            
               
            

           
            last = ks;
            
            base.Update(gameTime, clientBounds,collision);
        }
        public virtual void Draw2(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draw the sprite


           
            spriteBatch.Draw(textureImage,
                            position,
                            new Rectangle(currentFrame.X * frameSize.X,
                                currentFrame.Y * frameSize.Y,
                                frameSize.X, frameSize.Y),
                            Color.White, // This tints the sprite
                            0, // This rotates the sprite
                            new Vector2(0, 0), // This is where the origin of the sprite will be
                            new Vector2(1f,1f),
                            SpriteEffects.None,
                            0f);
        }
    }
}
