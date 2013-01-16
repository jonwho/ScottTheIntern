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

   public class Map3
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
    positionlist.Add(new Vector2(750,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(750,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,550));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(50,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,500));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(100,200));
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
    positionlist.Add(new Vector2(150,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,450));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,450));
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
    positionlist.Add(new Vector2(650,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(650,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,100));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(150,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(200,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(250,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,400));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,350));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(600,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,150));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,150));
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
    positionlist.Add(new Vector2(550,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,250));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(300,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(350,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(400,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(450,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(500,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(550,300));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(0,100));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,150));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,200));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,250));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,300));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,350));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,400));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,450));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,500));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(0,550));
   Currentframe.Add(new Point(4,1));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(100,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(50,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(0,550));
   Currentframe.Add(new Point(0,3));
    positionlist.Add(new Vector2(150,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(200,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(250,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(300,550));
   Currentframe.Add(new Point(2,3));
    positionlist.Add(new Vector2(400,550));
   Currentframe.Add(new Point(0,3));
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
    positionlist.Add(new Vector2(750,550));
   Currentframe.Add(new Point(1,3));
    positionlist.Add(new Vector2(750,100));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,150));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,200));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,250));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,300));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,350));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,400));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,450));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,500));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(750,550));
   Currentframe.Add(new Point(3,1));
    positionlist.Add(new Vector2(0,50));
   Currentframe.Add(new Point(9,2));
    positionlist.Add(new Vector2(0,0));
   Currentframe.Add(new Point(9,1));
    positionlist.Add(new Vector2(50,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(100,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(150,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(200,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(250,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(300,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(350,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(400,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(450,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(500,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(550,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(650,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(600,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(650,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(700,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(750,0));
   Currentframe.Add(new Point(10,1));
    positionlist.Add(new Vector2(50,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(100,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(150,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(200,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(250,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(300,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(350,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(400,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(450,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(500,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(550,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(600,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(650,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(700,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(750,50));
   Currentframe.Add(new Point(10,2));
    positionlist.Add(new Vector2(50,100));
   Currentframe.Add(new Point(6,5));
    positionlist.Add(new Vector2(50,150));
   Currentframe.Add(new Point(6,6));
    positionlist.Add(new Vector2(700,150));
   Currentframe.Add(new Point(5,6));
    positionlist.Add(new Vector2(700,100));
   Currentframe.Add(new Point(5,5));
    positionlist.Add(new Vector2(650,200));
   Currentframe.Add(new Point(0,2));
    positionlist.Add(new Vector2(700,500));
   Currentframe.Add(new Point(8,6));
    positionlist.Add(new Vector2(700,450));
   Currentframe.Add(new Point(8,5));
    positionlist.Add(new Vector2(650,500));
   Currentframe.Add(new Point(7,6));
    positionlist.Add(new Vector2(650,450));
   Currentframe.Add(new Point(7,5));
    positionlist.Add(new Vector2(700,350));
   Currentframe.Add(new Point(5,6));
    positionlist.Add(new Vector2(700,300));
   Currentframe.Add(new Point(5,5));
    positionlist.Add(new Vector2(50,250));
   Currentframe.Add(new Point(9,5));
    positionlist.Add(new Vector2(50,300));
   Currentframe.Add(new Point(9,6));
    positionlist.Add(new Vector2(100,300));
   Currentframe.Add(new Point(10,6));
    positionlist.Add(new Vector2(100,250));
   Currentframe.Add(new Point(10,5));
    positionlist.Add(new Vector2(50,400));
   Currentframe.Add(new Point(6,5));
    positionlist.Add(new Vector2(50,450));
   Currentframe.Add(new Point(6,6));
    positionlist.Add(new Vector2(100,500));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(550,500));
   Currentframe.Add(new Point(7,1));
    positionlist.Add(new Vector2(400,100));
   Currentframe.Add(new Point(6,1));
    positionlist.Add(new Vector2(350,100));
   Currentframe.Add(new Point(5,1));
    positionlist.Add(new Vector2(350,50));
   Currentframe.Add(new Point(5,0));
    positionlist.Add(new Vector2(400,50));
   Currentframe.Add(new Point(6,0));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(670,126 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(665,317 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(611,469 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(111,426 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(160,272 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(110,126 ), new Point(21, 52),0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(300,112), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(482,119), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(704,232), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(176,535), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(516,537), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
 items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(54,203), new Point(25, 25),0, new Point(0, 0), new Point(2, 1), Vector2.Zero,0));
}
public static void Update(GameTime gameTime, Rectangle clientBounds)
{
    if (Lvl1.scott.position.Y > 540)
    {
        Lvl1.scott.position.Y = 100;
        Lvl1.scott.position.X = 125;
        Lvl1.messages = "Welcome to the front desk";
        while (InteractiveItems.interns.Count > 0)
        {
            InteractiveItems.interns.RemoveAt(InteractiveItems.interns.Count - 1);
        }
        for (int x = 0; x < Map.internlist.Count; x++)
        {
            InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));
        }
        Lvl1.mapno = 2;
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
             Functions.collision(new Rectangle(5 + Lvl1.backx, 6, 795, 93), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(781 + Lvl1.backx, 91, 100, 503), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(-20 + Lvl1.backx, 82, 49, 517), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(-5 + Lvl1.backx, 578, 356, 20), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(402 + Lvl1.backx, 579, 386, 16), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(349 + Lvl1.backx, 96, 102, 55), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(47 + Lvl1.backx, 99, 53, 102), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(48 + Lvl1.backx, 241, 104, 111), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(48 + Lvl1.backx, 392, 53, 109), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(701 + Lvl1.backx, 97, 53, 105), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(696 + Lvl1.backx, 293, 56, 109), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(638 + Lvl1.backx, 448, 113, 103), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(106 + Lvl1.backx, 499, 41, 54), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
             Functions.collision(new Rectangle(550 + Lvl1.backx, 499, 48, 54), Lvl1.scott.scottr, Lvl1.scott.speed, Lvl1.collision);
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
             foreach (NPC intern in internlist)
            {

                intern.Draw(gameTime, spriteBatch);
            }
             foreach (InteractiveItems item in items)
            {

                item.Draw2(gameTime, spriteBatch);
            }
	}
    }
}
//Map Generated With Hector's Map Editor
