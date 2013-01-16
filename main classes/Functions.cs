using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScottTheIntern
{
    public class Functions
    {
        public static bool collision(Rectangle rec1,Rectangle rec2,Vector2 speed ,int[] colli)
        {
            if ((rec1.Bottom  >= rec2.Bottom-speed.Y 
                && rec1.Top < rec2.Bottom)
                && (rec1.Left + 5 <= rec2.Right 
                && rec1.Right - 5 >= rec2.Left))
            {
                
                colli[2] = 1;
                return true;
            }//up
            else if (rec1.Top - 1 <= rec2.Bottom+speed.Y 
                && rec1.Bottom > rec2.Bottom 
                && rec1.Left + 5 <= rec2.Right 
                && rec1.Right - 5 >= rec2.Left)
            {
                
                colli[3] = 1;
                return true;
            }//down
            else if ((rec1.Top <= rec2.Bottom 
                && rec1.Bottom > rec2.Bottom) 
                && (rec1.Left <= rec2.Right+speed.X 
                && rec1.Right - 10 > rec2.Left))
            {
                
                colli[1] = 1;
                return true;
            }//right
            else if ((rec1.Top <= rec2.Bottom 
                && rec1.Bottom > rec2.Bottom) 
                && (rec1.Left <= rec2.Right 
                && rec1.Right >= rec2.Left-speed.X))
            {
                
                colli[0] = 1;
                return true;
            }
            else
                return false;
        }
        public static void AI(ref Vector2 position, ref Vector2 speedd, int[] colli, ref int yframe,ref int col)
        {
            float x = position.X;
            float y = position.Y, distance;
            Random speed = new Random();
            x = Math.Abs(x - Lvl1.scott.position.X);
            y = Math.Abs(y - Lvl1.scott.position.Y);

            x = (float)Math.Pow(x, 2);
            y = (float)Math.Pow(y, 2);
            distance = (float)Math.Sqrt((x + y));
            if (distance < 200)
            {
                if (position.X < Lvl1.scott.position.X && colli[1] == 0)
                {
                    position.X += speedd.X;
                    yframe = 3;
                }
                else if (position.X > Lvl1.scott.position.X && colli[0] == 0)
                {
                    position.X -= speedd.X;
                    yframe = 2;
                }
                if (position.Y < Lvl1.scott.position.Y && colli[3] == 0)
                {
                    position.Y += speedd.Y;
                    yframe = 0;
                }
                else if (position.Y > Lvl1.scott.position.Y && colli[2] == 0)
                {
                    position.Y -= speedd.Y;
                    yframe = 1;
                }
                col = 1;
            }
            else
                col = 0;
        }
       
    }
   
}
