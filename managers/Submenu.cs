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
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Submenu : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;

        public static int menutype=-1;// 0=scott,1=items, 2=save,3=attack,4=Deffend, 5=exit
        SpriteFont sf,ds;
        Texture2D menu;
        int ypos, wide, heigth, xpos=218;
        string message;
        bool draw = false;
        public static int time=0, opnumber=0, move = 0,lim = 0,lim2 = 0;
        bool back = false;
        public static bool menuu = false, optionss= false,battle = true;
        public static bool yes = false,drawitem = false;
        KeyboardState last;
        public static string[] options= new string[50];
        public static button select;
        Vector2 size;
        string[] descriptions = new string[9];
        public static int subselect = -1,decision = -1;
        
        public Submenu(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            menu = Game.Content.Load<Texture2D>("images/pause menu");
            sf = Game.Content.Load<SpriteFont>("Font/SpriteFont1");
            ds = Game.Content.Load<SpriteFont>("Font/Descrip");
            select = new button(Game.Content.Load<Texture2D>("images/menu select"),
                     new Vector2(xpos + 135, 110), 0, new Point(0, 0), new Point(1, 1), new Point(121, 30));
            select.height = 35;
            //select.wide = 80;

            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();

            if (yes)
            {
                last = ks;
                yes = false;
            }
            
           
                //PAUSE
                //Scott
                if (menutype == 0)
                {
                    xpos = 218;
                    wide = 250;
                    heigth = 350;
                    ypos = 0;
                    message = "Attack: " + Game1.scott_att + "\nDefense: " + Game1.scott_def;
                    draw = true;
                    menuu = true;
                }
                //Items
                else if (menutype == 1)
                {
                    xpos = 218;
                    wide = 400;
                    heigth = 200;
                    ypos = 0;
                    opnumber = 0;
                    message = "Items";
                    drawitem = true;
                    draw = true;
                    menuu = true;

                    if (Inventory.itemcount > 0)
                    {
                        if (Inventory.position[(int)(select.position.X - lim) / 67] == 1)
                            Lvl1.messages = "This Item can give you +12 to +25 hp.";
                        else if (Inventory.position[(int)(select.position.X - lim) / 67] == 2)
                            Lvl1.messages = "This Item can give you 0 to +5 str.";
                        else if (Inventory.position[(int)(select.position.X - lim) / 67] == 4)
                            Lvl1.messages = "This Item gives you full hp";
                        else if (Inventory.position[(int)(select.position.X - lim) / 67] == 3)
                            Lvl1.messages = "This Item can give you 0 to +5 def.";
                        else if (Inventory.position[(int)(select.position.X - lim) / 67] == 5)
                            Lvl1.messages = "This Item can give you +5 to +50 Office Points.";

                          if(ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter))
                          {
                       
                                Inventory.useitem(Inventory.position[(int)(select.position.X - lim) / 67]);
                        
                          }
                           optionss = true;
                    }
                        
                    else
                        optionss = false;
                    //select.position = new Vector2(230,100);
                    select.wide = 67;
                    select.height = 50;
                    lim = 230;
                    lim2 = lim+((Inventory.itemcount-1)*67);
                    move = 67;
                    
                }
                //Save
                else if (menutype == 2)
                {
                    xpos = 218;
                    wide = 200;
                    heigth = 100;
                    ypos = 75;
                    message = "Save\nCompleted";
                   
                    
                    draw = true;
                    menuu = true;
                }


               //BATTLE
                //Atack
                else if (menutype == 3)
                {
                    xpos = 320;
                    ypos = 410;
                    wide = 300;
                    heigth = 180;
                    options[0] = "Slap";
                    options[1] = "Pen Stab";
                    options[2] = "Coffee Bomb";
                    options[3] = "Special Atack";
                    descriptions[0] = "This attack is not very\neffective. Using this attack \nscott will slap the intern\nlike a girl :D\n+1 OP per slap";
                    descriptions[1] = "This attack is more effective\nsince you get to stab an\nintern with a PEN\n5 OPs required";
                    descriptions[2] = "25 OPs required\n 50base damage only";
                    descriptions[3] = "50 OPs required\nWill either do an\ninstant kill or waste\nOPs, use wisely";
                    opnumber = 4;
                    battle = true;
                    draw = false;
                    subselect = 1;

                }
                //Deffend
                else if (menutype == 4)
                {
                    xpos = 320;
                    ypos = 410;
                    options[0] = "Folder";
                    options[1] = "Chair";
                    options[2] = "Cubical";
                    descriptions[0] = "5 OPs required\nAdds +10 defense\nDuration: 3 turns";
                    descriptions[1] = "10 OPs required\nAdds +20 defense\nDuration: 3 turns";
                    descriptions[2] = "20 OPs required\nAdds +35 defense\nDuration: 2 turns";
                    draw = false;
                    opnumber = 3;
                    battle = true;
                    subselect = 2;

                }
                //Items
                else if (menutype == 6)
                {
                    xpos = 320;
                    ypos = 410;
                    options[0] = "Zero Energy";
                    options[1] = "Bubble Tie";
                    options[2] = "Bluetooth";
                    descriptions[0] = "Add description here";
                    descriptions[1] = "Add description here";
                    descriptions[2] = "Add description here";
                    opnumber = 3;
                    battle = true;
                    draw = false;
                    menuu = true;
                    subselect = 3;
                }
                //menutype = -1;
            //}
            //Exit
            else if (menutype == 5)
            {
                message = "Are you sure you want to exit?";
                options[0] = "Yes";
                options[1] = "No";
                opnumber = 2;
                optionss = true;
                draw = true;
                wide = 400;
                heigth = 70;
                menuu = true;
                ypos = 75;
                xpos = 218;
                lim = 353;
                lim2 = 453;
                move = 100;
                select.height = 35;
                 if (ks.IsKeyDown(Keys.Enter) && last.IsKeyUp(Keys.Enter))
                {
                    if (select.position.X == 353)
                    {
                        if (Pause_menu.select.position.Y == 160)
                        {
                            menutype = -1;
                            drawitem = false;
                            draw = false;
                            menuu = false;
                            back = false;
                            optionss = false;
                            Game1.screen_selector = 6;
                            
                        }
                        else
                            this.Game.Exit();
                    }
                    else
                    {
                        back = true;
                        Pause_menu.yes = true;
                    }
                }
                
                
            }
                if (ks.IsKeyDown(Keys.Right) && last.IsKeyUp(Keys.Right)&& select.position.X<lim2)
                {
                    select.position.X += move;
                    audioframe.playSound(7);
                }
                else if (ks.IsKeyDown(Keys.Left) && last.IsKeyUp(Keys.Left) && select.position.X > lim)
                {
                    select.position.X -= move;
                    audioframe.playSound(7);
                }

            //Back
           
             if (ks.IsKeyDown(Keys.Escape) && last.IsKeyUp(Keys.Escape))
            {
                back = true;
                Pause_menu.yes = true;
            }
            //Atack selector
            
            last = ks;
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            if (draw==true)
            {
                if(menuu)
                spriteBatch.Draw(menu, new Rectangle(xpos, ypos, wide, heigth), Color.White);
                spriteBatch.DrawString(sf
                          , message,
                          new Vector2(xpos+12, ypos + 5), Color.Black);
                if (optionss)
                {
                    for (int x = 0; x < opnumber;x++ )
                    {
                        spriteBatch.DrawString(sf
                          , options[x],
                          new Vector2((xpos+140)+(100*x), ypos + 35), Color.Black);
                        if (select.position.X == (xpos + 135) + (100 * x))
                        {
                            size = sf.MeasureString(options[x]);
                            select.wide = (int)size.X + 10;
                        }
                    }
                    select.Drawslc(gameTime, spriteBatch);
                }
                if (drawitem)
                {
                    if (Inventory.item1.Count > 0)
                    {
                        for (int x = 0; x < 6; x++)
                        {

                            if (Inventory.position[x] == 1)
                            {
                                // pos = x ;
                                Inventory.item1[0].DrawItems(spriteBatch, x);
                            }
                        }

                    }
                    if (Inventory.item2.Count > 0)
                    {
                        for (int x = 0; x < 6; x++)
                        {

                            if (Inventory.position[x] == 2)
                            {
                                //pos = x;
                                Inventory.item2[0].DrawItems(spriteBatch, x);
                            }
                        }

                    }
                    if (Inventory.item3.Count > 0)
                    {
                        for (int x = 0; x < 6; x++)
                        {

                            if (Inventory.position[x] == 3)
                            {
                                //pos = x;
                                Inventory.item3[0].DrawItems(spriteBatch, x);
                            }
                        }

                    }
                    if (Inventory.item4.Count > 0)
                    {
                        for (int x = 0; x < 6; x++)
                        {

                            if (Inventory.position[x] == 4)
                            {
                                //pos = x;
                                Inventory.item4[0].DrawItems(spriteBatch, x);
                            }
                        }

                    }
                    if (Inventory.item5.Count > 0)
                    {
                        for (int x = 0; x < 6; x++)
                        {

                            if (Inventory.position[x] == 5)
                            {
                                //pos = x;
                                Inventory.item5[0].DrawItems(spriteBatch, x);
                            }
                        }

                    }
                }
                if(menutype==2)
                time += gameTime.ElapsedGameTime.Milliseconds;
                if (time > 500||back)
                {
                    drawitem = false;
                    draw = false;
                    menuu = false;
                    back = false;
                    optionss = false;
                    time = 0;
                    Game1.screen_selector = 5;
                }
            }
            else if (battle)
            {
                for (int x = 0; x < opnumber; x++)
                {
                   
                    spriteBatch.DrawString(sf
                      , options[x],
                      new Vector2(xpos, ypos ), Color.Black);
                    size = sf.MeasureString(options[x]);
                    ypos += (int)size.Y + 10;
                   
                    if (select.position.X == (xpos + 135) + (100 * x))
                    {
                        
                        select.wide = (int)size.X + 10;
                    }
                }
                //size.X = 0;
                if (menuu)
                {
                    spriteBatch.Draw(menu, new Rectangle(xpos+168, 410, wide, heigth), Color.White);
                    for (int x = 0; x < opnumber;x++ )
                        if (Battle1.select.position.Y == 412 + (44 * x))
                        {
                            spriteBatch.DrawString(ds
                                      , descriptions[x],
                                      new Vector2(xpos + 170, 412), Color.Black);
                            decision = x;
                        }
                }
            }
           
            

            spriteBatch.End();

            base.Draw(gameTime);
        }

       
    }
}