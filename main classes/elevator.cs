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

   public class Map5
    {
       public static Texture2D tile;
       public static Point framesize = new Point(50,50);
       public static List<Vector2> positionlist = new List<Vector2>();
       public static List<Point> Currentframe = new List<Point>();
       public static List<NPC> internlist = new List<NPC>();
       public static List<InteractiveItems> items = new List<InteractiveItems>();
       public static KeyboardState last;
public static void LoadContent(ContentManager Content)
       {
           tile = Content.Load<Texture2D>("images/test");
framesize = new Point(50,50);
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(0,4));
    positionlist.Add(new Vector2(350,200));
   Currentframe.Add(new Point(1,4));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(2,4));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(3,0));
    positionlist.Add(new Vector2(400,250));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(2,3));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(3,2));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(0,3));
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(4,0));
    positionlist.Add(new Vector2(300,250));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(4,2));
 
}
public static void Update(GameTime gameTime, Rectangle clientBounds)
{

    Lvl1.messages = "Press 1 to go to the front desk, and 0 to go to the CAVE ";
    KeyboardState ks = Keyboard.GetState();
    if (ks.IsKeyDown(Keys.D0) && last.IsKeyUp(Keys.D0))
    {
        while (InteractiveItems.interns.Count > 0)
        {
            InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count - 1);
        }
        for (int x = 0; x < Map4.internlist.Count; x++)
        {
            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
        }
        Lvl1.scott.position = new Vector2(720,535);
        Lvl1.backx = 0;
        Lvl1.mapno = 4;
        audioframe.office_theme_instance.Stop();
        audioframe.boss_instance.Play();
    }
    else if (ks.IsKeyDown(Keys.D1) && last.IsKeyUp(Keys.D1))
    {
        while (InteractiveItems.interns.Count > 0)
        {
            InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count - 1);
        }
        for (int x = 0; x < Map.internlist.Count; x++)
        {
            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
        }
        Lvl1.scott.position = Map.lastpo;
        Lvl1.backx = 0;
        Lvl1.mapno = 2;
    }
    else if (ks.IsKeyDown(Keys.B) && last.IsKeyUp(Keys.B))
    {
        while (InteractiveItems.interns.Count > 0)
        {
            InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count - 1);
        }
        for (int x = 0; x < Map.internlist.Count; x++)
        {
            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
        }
        
        Lvl1.backx = 0;
        Lvl1.mapno = 6;
    }
Functions.collision(new Rectangle(299+Lvl1.backx,338,153,38),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(437+Lvl1.backx,200,40,139),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(299+Lvl1.backx,177,138,37),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(278+Lvl1.backx,214,37,125),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
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
           
	}
    }
}
//Map Generated With Hector's Map Editor
