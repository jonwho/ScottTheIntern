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

   public class Map6
    {
       public static Texture2D tile;
       public static Point framesize = new Point(50,50);
       public static List<Vector2> positionlist = new List<Vector2>();
       public static List<Point> Currentframe = new List<Point>();
       public static List<NPC> internlist = new List<NPC>();
       public static List<InteractiveItems> items = new List<InteractiveItems>();
public static void LoadContent(ContentManager Content)
       {
           tile = Content.Load<Texture2D>("images/test");
framesize = new Point(50,50);
    positionlist.Add(new Vector2(100,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,50));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(100,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,100));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(600,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,500));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,450));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(150,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,150));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(550,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,400));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(200,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,200));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(500,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,350));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(250,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,300));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(450,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(400,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(350,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(300,250));
   Currentframe.Add(new Point(5,7));
    positionlist.Add(new Vector2(650,50));
   Currentframe.Add(new Point(9,10));
    positionlist.Add(new Vector2(650,100));
   Currentframe.Add(new Point(9,11));
    positionlist.Add(new Vector2(650,150));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,200));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,250));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,300));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,350));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,400));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,450));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(650,500));
   Currentframe.Add(new Point(4,8));
    positionlist.Add(new Vector2(100,50));
   Currentframe.Add(new Point(7,10));
    positionlist.Add(new Vector2(100,100));
   Currentframe.Add(new Point(7,11));
    positionlist.Add(new Vector2(100,150));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,200));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,250));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,300));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,350));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,400));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,450));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(100,500));
   Currentframe.Add(new Point(6,8));
    positionlist.Add(new Vector2(150,500));
   Currentframe.Add(new Point(0,3));
    positionlist.Add(new Vector2(600,500));
   Currentframe.Add(new Point(2,3));
    positionlist.Add(new Vector2(200,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(250,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(300,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(500,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(450,500));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(150,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(200,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(250,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(300,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(350,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(400,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(450,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(500,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(550,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(600,50));
   Currentframe.Add(new Point(8,10));
    positionlist.Add(new Vector2(150,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(200,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(250,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(300,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(450,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(500,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(550,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(600,100));
   Currentframe.Add(new Point(8,11));
    positionlist.Add(new Vector2(550,150));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(200,150));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(2,5));
    positionlist.Add(new Vector2(450,100));
   Currentframe.Add(new Point(3,5));
    positionlist.Add(new Vector2(400,150));
   Currentframe.Add(new Point(2,6));
    positionlist.Add(new Vector2(450,150));
   Currentframe.Add(new Point(3,6));
    positionlist.Add(new Vector2(350,400));
   Currentframe.Add(new Point(1,7));
    positionlist.Add(new Vector2(500,400));
   Currentframe.Add(new Point(1,7));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(163,498), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(172,470), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(169,437), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(622,149), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(149,151), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(616,497), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(362,155), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(502,163), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(629,240), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(627,362), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(153,204), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(162,369), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(154,317), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(176,315), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(197,310), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(220,311), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(242,312), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(264,311), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(285,313), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(306,314), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(180,238), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(272,248), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(225,282), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(511,239), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(505,275), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(532,314), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(574,323), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(613,313), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(617,289), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(612,256), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(599,240), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(577,236), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(557,229), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(542,225), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(530,229), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(544,271), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(595,279), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(572,311), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(396,373), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(417,386), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(390,389), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(383,404), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(377,410), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(494,419), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(557,389), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(406,302), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(423,262), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(327,409), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(268,348), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(263,445), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(220,405), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(473,473), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(548,471), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(486,362), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(355,319), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(288,181), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(372,253), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(320,231), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(380,214), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(469,229), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(621,210), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(445,337), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(385,487), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(296,491), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(248,488), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(239,441), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(216,476), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(222,370), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(286,409), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(355,356), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(327,368), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
}
public static void Update(GameTime gameTime, Rectangle clientBounds)
{
    if (Lvl1.scott.position.Y > 500)
    {
        Lvl1.mapno = 5;
        Lvl1.scott.position = new Vector2(350, 250);
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
Functions.collision(new Rectangle(653+Lvl1.backx,142,80,411),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(97+Lvl1.backx,525,254,41),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(447+Lvl1.backx,518,208,49),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(92+Lvl1.backx,144,58,383),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(132+Lvl1.backx,109,269,42),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(206+Lvl1.backx,152,40,52),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(554+Lvl1.backx,148,41,53),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(498+Lvl1.backx,119,193,27),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
Functions.collision(new Rectangle(402+Lvl1.backx,129,100,72),Lvl1.scott.scottr,Lvl1.scott.speed,Lvl1.collision);
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
