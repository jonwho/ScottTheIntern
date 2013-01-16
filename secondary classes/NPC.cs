using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScottTheIntern
{
    // NPC is a subclass of Sprite
    public class NPC : Sprite
    {
        public static Vector2 pos;
        public static int remove;
        public Rectangle npc;
        
        
        
       // public static int[] colli = {0,0,0,0};
        // NPC constructor that must inherently call super class constructor
        public NPC(Texture2D textureImage, Vector2 position, Point frameSize,
            int collisionOffset, Point currentFrame, Point sheetSize, Vector2 speed,
            int millisecondsPerFrame)
            : base(textureImage, position, frameSize, collisionOffset, currentFrame,
                sheetSize, speed, millisecondsPerFrame) { }
        

        public override void Update(GameTime gameTime, Rectangle clientBounds, int collision)
        {
            // Add necessary update components for NPC
             npc = new Rectangle((int)position.X,(int)position.Y, frameSize.X,frameSize.Y);
           
            Functions.AI(ref position, ref speed, colli,ref currentFrame.Y,ref col);
            
                if (Scott.left)
                {
                    position.X += Lvl1.scott.speed.X;
                   
                   
                }

               
                else if (Scott.right)
                {
                    position.X -= Lvl1.scott.speed.X;
                }

                           
                
            base.Update(gameTime, clientBounds,collision);
        }
        public Vector2 getPos()
        {
            return position;
        }
    }
}
