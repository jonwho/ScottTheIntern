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

   public class Map
    {
       public static Texture2D tile;
       public static Point framesize = new Point(50,50);
       public static List<Vector2> positionlist = new List<Vector2>();
       public static List<Point> Currentframe = new List<Point>();
       public static List<NPC> internlist = new List<NPC>();
       public static List<InteractiveItems> items = new List<InteractiveItems>();
       public static KeyboardState last;
       public static Vector2 lastpo;
public static void LoadContent(ContentManager Content)
       {
           tile = Content.Load<Texture2D>("images/test");
framesize = new Point(50,50);
    positionlist.Add(new Vector2(750,100));
   Currentframe.Add(new Point(4,0));
    positionlist.Add(new Vector2(750,150));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,200));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,250));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,300));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,350));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,400));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,450));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,500));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(750,550));
   Currentframe.Add(new Point(4,2));
    positionlist.Add(new Vector2(0,550));
   Currentframe.Add(new Point(3,2));
    positionlist.Add(new Vector2(0,500));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,450));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,400));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,350));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,300));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,250));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,200));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,150));
   Currentframe.Add(new Point(3,0));
    positionlist.Add(new Vector2(0,100));
   Currentframe.Add(new Point(3,0));
    positionlist.Add(new Vector2(0,150));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(50,100));
   Currentframe.Add(new Point(9,1));
    positionlist.Add(new Vector2(150,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(200,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(250,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(300,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(450,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(500,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(550,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(600,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(650,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(700,100));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(50,150));
   Currentframe.Add(new Point(9,2));
    positionlist.Add(new Vector2(150,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(200,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(250,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(300,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(350,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(400,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(450,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(500,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(550,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(600,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(650,150));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(700,150));
   Currentframe.Add(new Point(11,2));
    positionlist.Add(new Vector2(50,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(150,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(200,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(250,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(300,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(450,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(500,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(550,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(600,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(650,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(700,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(450,550));
   Currentframe.Add(new Point(0,3));
    positionlist.Add(new Vector2(350,550));
   Currentframe.Add(new Point(2,3));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(300,150));
   Currentframe.Add(new Point(2,5));
    positionlist.Add(new Vector2(350,150));
   Currentframe.Add(new Point(3,5));
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(2,6));
    positionlist.Add(new Vector2(350,200));
   Currentframe.Add(new Point(3,6));
    positionlist.Add(new Vector2(400,150));
   Currentframe.Add(new Point(2,5));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(2,6));
    positionlist.Add(new Vector2(450,200));
   Currentframe.Add(new Point(3,6));
    positionlist.Add(new Vector2(450,150));
   Currentframe.Add(new Point(3,5));
    positionlist.Add(new Vector2(550,100));
   Currentframe.Add(new Point(12,0));
    positionlist.Add(new Vector2(600,100));
   Currentframe.Add(new Point(13,0));
    positionlist.Add(new Vector2(550,150));
   Currentframe.Add(new Point(12,1));
    positionlist.Add(new Vector2(600,150));
   Currentframe.Add(new Point(13,1));
    positionlist.Add(new Vector2(50,100));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(50,150));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(150,100));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(150,150));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(700,200));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(50,200));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(700,500));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(250,200));
   Currentframe.Add(new Point(7,0));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(552,201 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(732,337 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(102,181 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(129,186 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(82,494 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(118,351 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(686,208), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(715,263), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(695,553), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(163,213), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(64,274), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(224,206), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(509,206), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(66,543), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(118,364), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(140,388), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 
}
public static void Update(GameTime gameTime, Rectangle clientBounds)
{
    if (Lvl1.scott.position.Y < 100)
    {
        Lvl1.scott.position.Y=530;
        Lvl1.scott.position.X = 380;
        Lvl1.messages = "Welcome to the Arcade room.";
        
        while (InteractiveItems.interns.Count > 0)
        {
            InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count - 1);
        }
        for (int x = 0; x < Map3.internlist.Count; x++)
        {
            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
        }
        Lvl1.mapno = 3;
    }
    foreach (NPC intern in internlist)
            {

                intern.Update(gameTime, clientBounds, 0);
            }

            foreach (NPC intern in internlist)
            {

                intern.colli[0] = 0;
                intern.colli[1] = 0;
                intern.colli[2] = 0;
                intern.colli[3] = 0;
            }
            for (int x = 0; x < internlist.Count; x++)
            {
                if (internlist[x].npc.Intersects(Lvl1.scott.scottr))
                {
                    Battle1.npc_hp = 50;
                    Battle1.npc_def = 20;
                    Battle1.npc_att = 20;
                    internlist.RemoveAt(x);
                    InteractiveItems.interns.RemoveAt(x);
                    Game1.screen_selector = 8;

                }
            }
             for (int x = 0; x < items.Count; x++)
            {
                Lvl1.itemsstate[x] = items[x].currentFrame.X;
            }

            foreach (InteractiveItems item in items)
            {

                item.Update(gameTime, clientBounds, 5);
            }
             for (int x = 0; x < positionlist.Count; x++)
            {
                if (Scott.left)
                {
                    positionlist[x] = new Vector2(positionlist[x].X + Lvl1.scott.speed.X, positionlist[x].Y);
                }
                else if (Scott.right)
                {

                    positionlist[x] = new Vector2(positionlist[x].X - Lvl1.scott.speed.X, positionlist[x].Y);
                }

            }
Functions.collision(new Rectangle(54,201,0,-1),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(649,98,101,104),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(748,86,34,513),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(451,579,297,18),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(37,574,368,25),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(23,82,30,492),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(150,91,152,109),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(496,98,55,103),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(323,571,-1,2),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(319,564,0,0),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(302,144,199,106),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(248,198,53,51),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(58,198,39,55),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(702,200,46,54),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(703,499,44,51),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(49,94,50,106),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(550,170,99,37),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Rectangle elevator = new Rectangle(550, 170, 99, 37);
    KeyboardState ks = Keyboard.GetState();
    if(Lvl1.scott.scottr.Intersects(elevator))
    {
        Lvl1.messages = "Press space bar to go to the elevator";
        if (ks.IsKeyDown(Keys.Space) && last.IsKeyUp(Keys.Space))
        {
            Lvl1.mapno = 5;
            lastpo = Lvl1.scott.position;
            Lvl1.scott.position = new Vector2(350,250);
            
        }
    }
}
        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int x = 0; x < positionlist.Count; x++)
            {
                spriteBatch.Draw(tile,
                           positionlist[x],
                           new Rectangle(Currentframe[x].X * framesize.X,
                               Currentframe[x].Y * framesize.Y,
                               framesize.X, framesize.Y),
                           Color.White,
                           0,
                           new Vector2(0, 0),
                           1f,
                           SpriteEffects.None,
                           0f);
            }
            
             foreach (InteractiveItems item in items)
            {

                item.Draw2(gameTime, spriteBatch);
            }
             foreach (NPC intern in internlist)
             {

                 intern.Draw(gameTime, spriteBatch);
             }
	}
    }
}
//Map Generated With Hector's Map Editor
