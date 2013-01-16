using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace ScottTheIntern
{
    // Create all items in this class.
    public class Item
    {
        int effect = 0;
        Random prob = new Random();
        float probb;
        public Vector2 position = new Vector2(230, 100);
       public static Texture2D items ,selectitem;
       public static SpriteFont sf;

        // Constructor for Item
        public Item(int effect) { this.effect = effect; }
        public static void loaditems(ContentManager Content)
        {
            
                items = Content.Load<Texture2D>("images/items");
                selectitem = Content.Load<Texture2D>("images/slectitem");
                sf = Content.Load<SpriteFont>("Font/SpriteFont1");
            
        }

        public int UseItem()
        {
            if (effect == 1)
            {
                probb=prob.Next(5,10)*0.1f;
                Game1.scott_hp += (int)(probb * 25);
                if (Game1.scott_hp > Game1.max_hp)
                    Game1.scott_hp = Game1.max_hp;
            }
            else if (effect == 2)
            {
                int curratt = Game1.scott_att;
                probb = prob.Next(1, 10) * 0.1f;
                Game1.scott_att += (int)(probb * 5);
                
            }
            else if (effect == 4)
            {
                int curratt = Game1.scott_att;

                Game1.scott_hp = Game1.max_hp;

            }
            else if (effect == 3)
            {
               
                int curratt = Game1.scott_att;
                probb = prob.Next(1, 10) * 0.1f;
                Game1.scott_def += (int)(probb * 5);

            }
            else if (effect == 5)
            {
                int curratt = Game1.scott_att;
                probb = prob.Next(1, 10) * 0.1f;
                Game1.scott_op += (int)(probb * 50);

            }
            return effect;
        }
        public void DrawItems(SpriteBatch spriteBatch,int position)
        {
            Point frameSize = new Point(67,50);
            int number_items=0;
            if (effect == 1)
            {
                number_items = Inventory.item1.Count;
            }
            else if (effect == 2)
            {
                number_items = Inventory.item2.Count;
            }
            else if (effect == 3)
            {
                number_items = Inventory.item3.Count;
            }
            else if (effect == 4)
            {
                number_items = Inventory.item4.Count;
            }
            else if (effect == 5)
            {
                number_items = Inventory.item5.Count;
            }
            else if (effect == 6)
            {
                number_items = Inventory.itemsp.Count;
            }
           
                spriteBatch.Draw(items,
                                new Vector2(230+(67*position),100),
                                new Rectangle((effect-1) * frameSize.X,
                                    0,
                                    frameSize.X, frameSize.Y),
                                Color.White,
                                0,
                                new Vector2(0, 0),
                                1f,
                                SpriteEffects.None,
                                0f);
                spriteBatch.DrawString(sf
                             ,"X "+number_items.ToString(),
                             new Vector2(243 + (67 * position), 155), Color.Black);
                 
        }


        // Creating all possible items we'll have in this game.
        // Made static so accessible without instantiating the Item class itself.
        // Random numbers for now, change later as pleased.
        //from 1 to 10 potions or temporal power things
        //1=heal pot, 2=atack increase, 3= def increase, 4= max health, more ideas are welcome
        //11 to 20 special attacks
        //21 to 30 apparels just if elvis wants to draw:D
        //31 to ∞ something else
       
        
    }
}
