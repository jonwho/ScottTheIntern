using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.IO;

namespace ScottTheIntern
{
    class save_game
    {
        public static StreamWriter sw = null;
        public static decimal count = 0;
        public static string[] count_reader, save_reader;
        public static int constant = 20, internconstant = 5;

        public static void save(string name, int save_number)
        {
            if (!File.Exists("save_count.txt"))//if there no files create them
            {
                sw = File.CreateText("save_count.txt");
                sw.WriteLine(count);
                
                sw.Close();
                sw = null;
                sw = File.AppendText("save.txt");
                sw.Close();
                sw = null;
            }
            else if (File.Exists("save_count.txt"))//if files exist put them in string
            {
                count_reader = File.ReadAllLines("save_count.txt");

                count = System.Convert.ToDecimal(count_reader[0]);
                save_reader = File.ReadAllLines("save.txt");
            }
            if (count == 0)// if no saves save it
            {
                sw = File.CreateText("save_count.txt");
                sw.WriteLine(++count);
                sw.Close();
                sw = null;
                sw = File.AppendText("save.txt");
                sw.WriteLine(name);
                sw.WriteLine(Lvl1.position.X);
                sw.WriteLine(Lvl1.position.Y);
                sw.WriteLine(Lvl1.backx);
                for (int x = 0; x < 6; x++)
                {
                    sw.WriteLine(Map1.items[x].currentFrame.X);
                }
                for (int x = 0; x < Map1.internlist.Count; x++)
                {
                    sw.WriteLine(Map1.internlist[x].position.X);
                }
                int coun = Map1.internlist.Count;
                while (coun < internconstant)
                {
                    sw.WriteLine("-1");
                    coun++;
                }//change put while in here re format
                for (int x = 0; x < Map1.internlist.Count; x++)
                {
                    sw.WriteLine(Map1.internlist[x].position.Y);
                }
                 coun = Map1.internlist.Count;
                while (coun < internconstant)
                {
                    sw.WriteLine("-1");
                    coun++;
                }
                //sw.WriteLine();
                //sw.WriteLine();
                sw.Close();
                Game1.savedno = 1;

            }
            else if (save_number>=0)//this is supposed to save the game if there is an existing game saved
            {
                //save_reader = File.ReadAllLines("save.txt"); // fix
                save_reader[ (save_number* constant)-19] = Lvl1.position.X.ToString();// fix
                save_reader[(save_number* constant)-18] = Lvl1.position.Y.ToString();// fix
                save_reader[(save_number * constant) - 17] = Lvl1.backx.ToString();
                //from here to 10 more are gonna b the boxes
                for (int x = 0; x < 6; x++)
                {
                    save_reader[(save_number * constant) - (16-x)] = Lvl1.itemsstate[x].ToString();
                }
                for (int x = 0; x < Map1.internlist.Count; x++)
                {
                    save_reader[(save_number * constant) - (10 - x)] = Map1.internlist[x].position.X.ToString(); 
                }
                if (Map1.internlist.Count < 5)
                {
                    for (int x = Map1.internlist.Count; x < internconstant; x++)
                    {
                        save_reader[(save_number * constant) - (10 - x)] = "-1";
                    }
                }
                for (int x = 0; x < Map1.internlist.Count; x++)//maybe change constant
                {
                    save_reader[(save_number * constant) - (5 - x)] =Map1.internlist[x].position.Y.ToString();
                }
                if (Map1.internlist.Count < internconstant)
                {
                    for (int x = Map1.internlist.Count; x < internconstant; x++)
                    {
                        save_reader[(save_number * constant) - (5 - x)] = "-1";
                    }
                }
                //save_reader[(save_number * constant) - 10] = Lvl1.itemsstate[0].ToString();//
                //save_reader[(save_number * constant) - 9] = Lvl1.itemsstate[1].ToString();
                //save_reader[(save_number * constant) - 8] = Lvl1.itemsstate[2].ToString();
                //save_reader[(save_number * constant) - 7] = Lvl1.itemsstate[3].ToString();
                //save_reader[(save_number * constant) - 6] = Lvl1.itemsstate[4].ToString();
                //save_reader[(save_number * constant) - 5] = Lvl1.itemsstate[5].ToString();//
                //save_reader[(save_number * constant) - 4] = Lvl1.itemsstate[6].ToString();
                //save_reader[(save_number * constant) - 3] = Lvl1.itemsstate[7].ToString();
                //save_reader[(save_number * constant) - 2] = Lvl1.itemsstate[8].ToString();
                //save_reader[(save_number * constant) - 1] = Lvl1.itemsstate[9].ToString();
                sw = File.CreateText("save.txt");
                for (int x = 0; x < count * constant; x++)
                {
                    
                    sw.WriteLine(save_reader[x]);
                }
                sw.Close();
                
            }
             else if(save_number<0)// if save number is negative it is not continue
            {
                sw = File.CreateText("save_count.txt");
                sw.WriteLine(++count);
                sw.Close();
                sw = File.AppendText("save.txt");
                sw.WriteLine(name);
                sw.WriteLine(Lvl1.position.X);
                sw.WriteLine(Lvl1.position.Y);
                sw.WriteLine(Lvl1.backx);
                for (int x = 0; x < 6; x++)
                {
                    sw.WriteLine(Map1.items[x].currentFrame.X);
                }
                for (int x = 0; x < Map1.internlist.Count; x++)
                {
                    sw.WriteLine(Map1.internlist[x].position.X);
                }
                int coun = Map1.internlist.Count;
                while (coun < internconstant)
                {
                    sw.WriteLine("-1");
                    coun++;
                }//change put while in here re format
                for (int x = 0; x < Map1.internlist.Count; x++)
                {
                    sw.WriteLine(Map1.internlist[x].position.Y);
                }
                 coun = Map1.internlist.Count;
                while (coun < internconstant)
                {
                    sw.WriteLine("-1");
                    coun++;
                }
               // sw.WriteLine();
                //sw.WriteLine();
                //sw.WriteLine();
                //sw.WriteLine();
                //sw.WriteLine();
                sw.Close();
                Game1.savedno = (int)count;

            }

        }
        public static string[] continuegame(ref decimal savedno)
        {
            string[] namesc= new string[200];
            if (!File.Exists("save_count.txt"))//if there no files create them
            {
                sw = File.CreateText("save_count.txt");
                sw.WriteLine(count);
                sw.Close();
                sw = null;
                sw = File.AppendText("save.txt");
                sw.Close();
                sw = null;
                savedno = 0;
                namesc[0] = "There are no saved games";
                return namesc;
            }
            else if (File.Exists("save_count.txt"))//if files exist put them in string
            {
                count_reader = File.ReadAllLines("save_count.txt");

                savedno = System.Convert.ToDecimal(count_reader[0]);
                if (savedno != 0)
                {
                    save_reader = File.ReadAllLines("save.txt");
                    for (int x = 0; x < savedno; x++)
                    {
                        namesc[x] = save_reader[x * constant];
                    }
                }
                else if (savedno == 0)
                    namesc[0] = "There are no saved games";

                return namesc;
            }
            else
                return namesc;
            

        }
        public static void loadgame(int save_number)
        {

            
            Lvl1.position.X = (float)System.Convert.ToDecimal(save_reader[((save_number*constant)-19)]);
            Lvl1.position.Y = (float)System.Convert.ToDecimal(save_reader[((save_number* constant)-18)]);
            Lvl1.backx = (int)System.Convert.ToDecimal(save_reader[((save_number * constant) - 17)]);
            int xx = 6+(internconstant*2);
            for (int x = 0; x < 6; x++)
            {
                Lvl1.itemsstate[x] = (int)System.Convert.ToDecimal(save_reader[((save_number * constant) - xx)]);
                xx--;
            }
            int y = internconstant*2;
            for (int x = 0; x < internconstant; x++)
            {
                Map1.internlist[x].position=new Vector2(
                    (float)System.Convert.ToDecimal(save_reader[((save_number * constant) - (10-x))]),
                    (float)System.Convert.ToDecimal(save_reader[((save_number * constant) - (5 - x))]));
            }
           
            
        }
    }
}
