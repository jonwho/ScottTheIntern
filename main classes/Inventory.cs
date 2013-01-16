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
    // This will store all items that Scott gains throughout the game.
    public static class Inventory
    {
        // Made static so ItemList will be accessible without having to instantiate the Iventory class.
        // Only stores the class Item.
        // With this use ArrayList as you normally would.
        // Had to change to List because it wouldnt compile otherwise-Isidro to Jon
        public static List<Item> item4 = new List<Item>();
        public static List<Item> item1 = new List<Item>();
        public static List<Item> item2 = new List<Item>();
        public static List<Item> item3 = new List<Item>();
        public static List<Item> item5 = new List<Item>();
        public static List<Item> itemsp = new List<Item>();
        public static Random rand = new Random();
        public static int[] position={0,0,0,0,0,0};
        public static int itemcount=0;
        public static void inventory(int itemno)
        {
            if (itemno == 1)
            {
                
                if (item1.Count == 0)
                {
                    position[itemcount++] = 1;
                    
                }
                item1.Add(new Item(1));

            }
            else if (itemno == 2)
            {
                
                if (item2.Count == 0)
                {
                    position[itemcount++] = 2;
                }
                item2.Add(new Item(2));
            }
            else if (itemno == 3)
            {
                
                if (item3.Count == 0)
                {
                    position[itemcount++] = 3;
                }
                item3.Add(new Item(3));
            }
            else if (itemno == 4)
            {
                
                if (item4.Count == 0)
                {
                    position[itemcount++] = 4;
                }
                item4.Add(new Item(4));
            }
            else if (itemno == 5)
            {
                
                if (item5.Count == 0)
                {
                    position[itemcount++] = 5;
                }
                item5.Add(new Item(5));
            }
            else if (itemno == 6)
            {
                
                if (itemsp.Count == 0)
                {
                    position[itemcount++] = 6;
                }
                itemsp.Add(new Item(rand.Next(6, 10)));
            }
        }
        public static void useitem(int itemno)
        {
            if (itemno == 1)
            {
                item1[item1.Count-1].UseItem();
                item1.RemoveAt(item1.Count - 1);
                if (item1.Count == 0)
                {
                    for (int x = 0; x < 6;x++ )
                        if (position[x] == 1)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            else if (itemno == 2)
            {
                item2[item2.Count - 1].UseItem();
                item2.RemoveAt(item2.Count - 1);
                if (item2.Count == 0)
                {
                    for (int x = 0; x < 6; x++)
                        if (position[x] == 2)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            else if (itemno == 3)
            {
                item3[item3.Count - 1].UseItem();
                item3.RemoveAt(item3.Count - 1);
                if (item3.Count == 0)
                {
                    for (int x = 0; x < 6; x++)
                        if (position[x] == 3)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            else if (itemno == 4)
            {
                item4[item4.Count - 1].UseItem();
                item4.RemoveAt(item4.Count - 1);
                if (item4.Count == 0)
                {
                    for (int x = 0; x < 6; x++)
                        if (position[x] == 4)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            else if (itemno == 5)
            {
                item5[item5.Count - 1].UseItem();
                item5.RemoveAt(item5.Count - 1);
                if (item5.Count == 0)
                {
                    for (int x = 0; x < 6; x++)
                        if (position[x] == 5)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            else if (itemno == 6)
            {
                itemsp[itemsp.Count - 1].UseItem();
                itemsp.RemoveAt(itemsp.Count - 1);
                if (itemsp.Count == 0)
                {
                    for (int x = 0; x < 6; x++)
                        if (position[x] == 6)
                        {
                            position[x] = 0;
                            if (x + 1 < 6 && position[x + 1] != 0)
                            {
                                for (int y = x; y + 1 < itemcount; y++)
                                {
                                    position[y] = position[y + 1];
                                    //position[x + 1] = 0;
                                }
                                position[itemcount-1] = 0;
                            }
                            itemcount--;
                        }
                }
            }
            audioframe.playSound(3);
        }
        public static int item_count()
        {
            int itemco = 0;
            if (item1.Count > 0)
                itemco++;
            if (item2.Count > 0)
                itemco++;
            if (item3.Count > 0)
                itemco++;
            if (item4.Count > 0)
                itemco++;
            if (item5.Count > 0)
                itemco++;
            int spitem = itemsp.Count;
            while (spitem > 0)
            {
                itemco++;
                spitem--;
            }
            return itemco;

        }
        
    }
}
