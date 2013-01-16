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
    class Battle1 : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Texture2D background;
        Texture2D menu;
        Texture2D hp, hpt;
        public static button select;
        SpriteFont sf;
        public static Random attack_gen = new Random();
        Scott scott;
        NPC npc_sprite;
        //Sprite npc_hp_bar;
        string[] options = { "Attack", "Defend", "Use Item" };
        Vector2 size;
        KeyboardState last;
        bool internattack = false,usrattack= true,yes=true;

        //test variables
        static int damage, heigth = 150;
        static int scott_damage;

        //timer for time based battle
        int timer;
        int timer2;

        //variables for npc in battle
        public static int npc_hp = 0;
        public static int npc_def = 0;
        public static int npc_att = 0;

        //defense variables
        static int defense_turn=0, defense_boost = 0;
          
        static int item_use = 0;

        

        public Battle1(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
            
        }

        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }
        public static void scott_att_choice(int x)
        {
            if (x == 1)
                scott_slap();
            else if (x == 2)
            {
                if(Game1.scott_op >= 5)
                    scott_pen_stab();
            }
            else if (x == 3)
            {
                if(Game1.scott_op >= 25)
                    coffee_bomb();
            }
            else if (x == 4)
            {
                if(Game1.scott_op >= 50)
                    scott_finisher();
            }
            audioframe.playSound(6);
        }
        public static void scott_def_choice(int x)
        {
            if (defense_turn == 0)
            {
                if (x == 1 && Game1.scott_op >= 5)
                    scott_folder_defend();
                else if (x == 2 && Game1.scott_op >= 10)
                    scott_chair_defend();
                else if (x == 3 && Game1.scott_op >= 20)
                    scott_cubical_defend();
                audioframe.playSound(8);
            }
        }


        public static void scott_slap()
        {
            // get npc rect, draw blood particle splattering northeast
            damage = (int)(Game1.scott_att + 5) / (npc_def / 3) + attack_gen.Next(3, 7);
            npc_hp -= damage;
            if (Game1.scott_op < 100)
                Game1.scott_op += 1;
            
        }

        public static void scott_pen_stab()
        {
            // get npc rect, draw pen ink particle flying
            damage = (int)(Game1.scott_att + 20)/ ((npc_def * 2) / 3) + attack_gen.Next(-2, 10);
            npc_hp -= damage;
            Game1.scott_op -= 5;
        }

        public static void scott_finisher()
        {
            int test = attack_gen.Next(0, 20);
            if (npc_hp <= 200)
                if (test < 9 && test > -1)
                {
                    npc_hp -= npc_hp;
                    damage = npc_hp;
                }
                else
                {
                    npc_hp -= 0;
                    damage = 0;
                }
            Game1.scott_op -= 50;
        }

        public static void coffee_bomb()
        {
            //will require 2 cups of coffee to use
            // draw coffee particles raining onto npc
            npc_hp -= 50; 
            damage = 50;
            Game1.scott_op -= 25;
        }

        public static void scott_folder_defend()
        {
            //will require 5 OPs
            defense_boost = 10;
            defense_turn = 3;
            Game1.scott_op -= 5;
            
        }
        public static void scott_chair_defend()
        {
            //will require 10 OPs
            defense_boost = 20;
            defense_turn = 3;
            Game1.scott_op -= 10;
        }
        public static void scott_cubical_defend()
        {
            //will require 20 OPs
            defense_boost = 35;
            defense_turn = 2;
            Game1.scott_op -= 20;
        }
        public void scott_use_item()
        {
            //wait for item class
            //and will probably go in the Game1 class
        }
        public void intern_defend()
        {
            npc_def *= 2;
            scott_damage = 0;
   
        }

        public void intern_attack()
        {

            if (npc_hp < 20 && npc_hp > 5)
            {
                if (item_use == 1)
                    intern_defend();
                else
                {
                    npc_hp += 15;
                    item_use++;
                }
            }
            else
            {
                scott_damage = npc_att / (Game1.scott_def + defense_boost / 5) + attack_gen.Next(-2, 5);
                if (scott_damage < 0)
                    scott_damage = 0;
                Game1.scott_hp -= scott_damage;
                if(defense_turn != 0)
                    defense_turn--;//takes 1 turn
                if (defense_turn <= 0)
                {
                    defense_turn = 0;
                    defense_boost = 0;
                }
            }

        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            select = new button(Game.Content.Load<Texture2D>("images/menu select"),
                      new Vector2(45, 420), 0, new Point(0, 0), new Point(1, 1), new Point(121, 30));
            background = Game.Content.Load<Texture2D>("images/battlebgdummy");
            menu = Game.Content.Load<Texture2D>("images/Fight menu");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            scott = new Scott(Game.Content.Load<Texture2D>("images/Scottbattle"), new Vector2(50, 335), new Point(35, 57), 16,
                                new Point(0, 0), new Point(1, 1), new Vector2(0, 0), 0);
            if(Game1.boss_npc == false)
                npc_sprite = new NPC(Game.Content.Load<Texture2D>("images/enemyintern"), new Vector2(600, 235), new Point(108, 156), 16,
                                new Point(0, 0), new Point(1, 1), new Vector2(0, 0), 0);
            else
                npc_sprite = new NPC(Game.Content.Load<Texture2D>("images/JonHoo"), new Vector2(600, 235), new Point(144, 167), 16,
                                new Point(0, 0), new Point(1, 1), new Vector2(0, 0), 0);
             hp= Game.Content.Load<Texture2D>("images/npc_hp1");
            hpt = Game.Content.Load<Texture2D>("images/npc_hp2");

            //image for npc health is "npc_hp1" when full
            //and image for npc health when empty is "npc_hp2" 

            select.height = 30;
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            if (Game1.boss_npc == true)
            {
                
                npc_sprite = new NPC(Game.Content.Load<Texture2D>("images/JonHoo"), new Vector2(600, 235), new Point(144, 167), 16,
                               new Point(0, 0), new Point(1, 1), new Vector2(0, 0), 0);
                
                
                Game1.boss_npc = false;
            }
            else if (Game1.normal_npc == true)
            {
                
                npc_sprite = new NPC(Game.Content.Load<Texture2D>("images/enemyintern"), new Vector2(600, 235), new Point(144, 167), 16,
                               new Point(0, 0), new Point(1, 1), new Vector2(0, 0), 0);

                
                Game1.normal_npc = false;
            }
            if(npc_hp <= 0)
                timer2 += gameTime.ElapsedGameTime.Milliseconds;
            if (npc_hp >= 0 && timer > 500)
            {
                //Game1.scott_def += defense_boost;
                intern_attack();
                internattack = false;
                usrattack = true;
                timer = 0;
               

            }
            
            else if (npc_hp <= 0 && timer > 3000)
            {
                
                
                Game1.screen_selector = 3;
            }
            else if (internattack)
            {
                timer += gameTime.ElapsedGameTime.Milliseconds;

            }

            KeyboardState ks = Keyboard.GetState();
            if (yes)
            {
                last = ks;
                yes = false;
            }

            if (ks.IsKeyDown(Keys.Up) && last.IsKeyUp(Keys.Up) && select.position.Y > 420)
            {
                if(select.position.X==45)
                select.position.Y -= 50;
                else if (select.position.X == 318)
                    select.position.Y -= 44;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Down) && last.IsKeyUp(Keys.Down) && select.position.Y < 520)
            {
                if (select.position.X == 45)
                    select.position.Y += 50;
                else if (select.position.X == 318&&select.position.Y<(350+(44*Submenu.opnumber)))
                    select.position.Y += 44;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Right) && last.IsKeyUp(Keys.Right) && select.position.X != 318)
            {
                select.position.X = 318;
                select.position.Y = 412;
                Submenu.menuu = true;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Left) && last.IsKeyUp(Keys.Left) && select.position.X == 318)
            {
                select.position.X = 45;
                select.position.Y = 420;
                Submenu.menuu = false;
                audioframe.playSound(7);
            }
            else if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter) && select.position.X == 318 && usrattack && npc_hp > 0)
            {
                if (Submenu.subselect == 1)
                {
                    scott_att_choice(Submenu.decision+1);
                    internattack = true;
                    usrattack = false;
                }
                else if (Submenu.subselect == 2)
                {

                    scott_def_choice(Submenu.decision + 1);
                    internattack = true;
                    usrattack = false;
                }
                else if (Submenu.subselect == 3)
                {
                        if(Inventory.item1.Count>0)
                   Inventory.useitem(Submenu.decision+1);
                    // scott_item_choice(Submenu.decision + 1);
                }

            }

           
                if (select.position.Y == 420)
                {
                    Submenu.menutype = 3;

                }

                else if (select.position.Y == 470)
                {
                    Submenu.menutype = 4;
                }

                else if (select.position.Y == 520)
                {
                    
                    Submenu.menutype = 6;

                }
                Submenu.yes = true;
                Game1.screen_selector = 7;
            
            last = ks;
            if (select.position.X == 45)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (select.position.Y == (420 + (50 * x)))
                    {
                        size = sf.MeasureString(options[x]);
                        select.wide = (int)size.X + 15;
                    }
                }
            }
            else
            {
                for (int x = 0; x < Submenu.opnumber; x++)
                {
                    
                    if (select.position.Y == (412 + (44 * x)))
                    {
                        size = sf.MeasureString(Submenu.options[x]);
                        select.wide = (int)size.X + 5;
                    }
                }
            }

            if (Game1.scott_hp <= 0)
            {
                Game1.scott_hp = 0;
                Game1.screen_selector = 6;
            }
            else if (npc_hp <= 0)
            {
                npc_hp = 0;
                if (Game1.boss_npc == true)
                {
                    audioframe.boss_instance.Stop();
                    audioframe.office_theme_instance.Play();
                    Game1.boss_npc = false;
                }
            }
              
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            
            heigth = npc_hp ;
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.Draw(menu, new Rectangle(0, 400, 800, 200), Color.White);

            scott.Draw(gameTime, spriteBatch);
            npc_sprite.Draw(gameTime, spriteBatch);
            for (int x = 0; x < 3; x++)
            {
                spriteBatch.DrawString(sf
                    , options[x],
                    new Vector2(50, 420 + (50 * x)), Color.Black);


            }

            select.Drawslc(gameTime, spriteBatch);
            //this is just to see if the boosts and timer are working
            //remove after check
            if(damage > 9 && damage <= 29)
                spriteBatch.DrawString(sf, "CRITICAL HIT!!!!" , new Vector2(520, 200), Color.Yellow);
            else if(damage > 30)
                spriteBatch.DrawString(sf, "Hot Coffee!!!", new Vector2(520, 200), Color.Red);

            
            if (npc_hp <= 0)
                spriteBatch.DrawString(sf, "You Win", new Vector2(350, 150), Color.Red);
            if (Game1.scott_hp <= 0)
            {
                spriteBatch.DrawString(sf, "You are a Failure", new Vector2(350, 250), Color.Red);
                Game1.screen_selector = -1;
            }
            if (npc_hp <= 0 && timer2 > 1250)
            {
                select.position = new Vector2(45, 420);
                scott_damage = 0;
                damage = 0;
                //InteractiveItems.interns.RemoveAt(NPC.remove);
                //Lvl1.internlist.RemoveAt(NPC.remove);
                yes = true;
                Game1.screen_selector = 3;
                audioframe.playSound(5);
                Game1.coffee_amount++;
                timer2 = 0;
            }
            spriteBatch.Draw(hp,
                            new Vector2(620 + (150 - heigth), 160),
                            new Rectangle(150 - heigth,0
                                ,
                                150+(heigth-150), 50),
                            Color.White, // This tints the sprite
                            0, // This rotates the sprite
                            new Vector2(0, 0), // This is where the origin of the sprite will be
                            1f,
                            SpriteEffects.None,
                            0.5f);
            spriteBatch.Draw(hpt, new Rectangle(620, 160, 150, 50), Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
