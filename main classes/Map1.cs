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
    public class Map1
    {
        public static List<NPC> internlist = new List<NPC>();
        public static int intern_number = 5;
        public static List<InteractiveItems> items = new List<InteractiveItems>();
        public static Texture2D background;
        public static void LoadContent(ContentManager Content)
        {
            background = Content.Load<Texture2D>("images/lvl1.2");
            for (int x = 0; x < intern_number; x++)
            {
                internlist.Add(new NPC(Content.Load<Texture2D>("images/enewalkinghector"), new Vector2(200 + (50 * x), 530), new Point(21, 52),
                                0, new Point(0, 0), new Point(8, 4), new Vector2(1, 1), 50));
               
                
                InteractiveItems.interns.Add(new Rectangle(0, 0, 1, 1));



            }
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(546, 416), new Point(25, 25),
              0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(845, 187), new Point(25, 25),
              0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(945, 57), new Point(25, 25),
               0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
               0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(1761, 464), new Point(25, 25),
               0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
               0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(1470, 30), new Point(25, 25),
              0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/openboxsmll"), new Vector2(1546, 553), new Point(25, 25),
              0, new Point(0, 0), new Point(2, 1), Vector2.Zero,
              0));


            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/sidewalkl"), new Vector2(500, 106), new Point(45, 350),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/coffee"), new Vector2(195, 262), new Point(305, 195),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/drvtru"), new Vector2(140, 341), new Point(56, 116),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/sidewalk"), new Vector2(895, 0), new Point(45, 496),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/bleft"), new Vector2(1532, 375), new Point(121, 73),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));


            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/bright"), new Vector2(1679, 375), new Point(120, 73),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/building"), new Vector2(1532, 0), new Point(267, 375),
              0, new Point(0, 0), new Point(1, 1), Vector2.Zero,
              0));
            items.Add(new InteractiveItems(Content.Load<Texture2D>("images/door"), new Vector2(1653, 375), new Point(26, 73),
              0, new Point(0, 0), new Point(2, 1), new Vector2(1,0),
              0));
        }
        public static void Update(GameTime gameTime, Rectangle clientBounds)
        {
            for (int x = 0; x < 6; x++)
            {
                Lvl1.itemsstate[x] = items[x].currentFrame.X;
            }
            for (int x = 0; x < items.Count - 1; x++)
            {
                if (x < 6)
                    items[x].Update(gameTime, clientBounds, 5);
                else
                    items[x].Update(gameTime, clientBounds, 0);
            }
            if (items[13].currentFrame.X != 1)
            {
                items[13].Update(gameTime, clientBounds, 5);
            }
            else
                items[13].Update(gameTime, clientBounds, 3);

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
           
        }
        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Rectangle(Lvl1.backx, 0, 1800, 600), Color.White);
            for (int x = 0; x < 10; x++)
                items[x].Draw2(gameTime, spriteBatch);
            if (items[13].currentFrame.X == 0)
            {
                items[13].Draw2(gameTime, spriteBatch);

            }
            if (Lvl1.scott.position.Y > 395)
            {

                items[10].Draw2(gameTime, spriteBatch);
                items[11].Draw2(gameTime, spriteBatch);
            }
        }
        public static void Draw2(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (items[13].currentFrame.X == 1)
            {
                items[13].Draw2(gameTime, spriteBatch);

            }
            if (Lvl1.scott.position.Y <= 395)
            {

                items[10].Draw2(gameTime, spriteBatch);
                items[11].Draw2(gameTime, spriteBatch);
            }

            items[12].Draw2(gameTime, spriteBatch);

            foreach (NPC intern in internlist)
            {

                intern.Draw(gameTime, spriteBatch);
            }

               
        }
    }
}
