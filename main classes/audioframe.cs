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
   
    public class audioframe 
    {
        
        static SoundEffect effect;
        static SoundEffect boss_song;
        static SoundEffect office_theme;
        static SoundEffect item_found;
        static SoundEffect before_boss;
        static SoundEffect hp_up;
        static SoundEffect item_not_found;
        static SoundEffect enemy_destroyed;
        static SoundEffect hit;
        static SoundEffect menu_scoller;
        static SoundEffect defense;
        static SoundEffect intern_sound;
        public static SoundEffectInstance song2;
        public static SoundEffectInstance boss_instance;
        public static SoundEffectInstance office_theme_instance;
        
        
        public static void LoadContent(ContentManager Content)
        {
            //effect = Content.Load<SoundEffect>("Audio/laser");
            effect = Content.Load<SoundEffect>("sounds/Title");
            boss_song = Content.Load<SoundEffect>("sounds/Boss");
            office_theme = Content.Load<SoundEffect>("sounds/The Office");
            boss_instance = boss_song.CreateInstance();
            office_theme_instance = office_theme.CreateInstance();
            song2=effect.CreateInstance();

            office_theme_instance.IsLooped = true;
            boss_instance.IsLooped = true;
            item_found = Content.Load<SoundEffect>("sounds/item_found");
            before_boss = Content.Load<SoundEffect>("sounds/before_fight");
            hp_up = Content.Load<SoundEffect>("sounds/potion");
            item_not_found = Content.Load<SoundEffect>("sounds/item_not_found");
            enemy_destroyed = Content.Load<SoundEffect>("sounds/enemy_destroyed");
            hit = Content.Load<SoundEffect>("sounds/hit");
            menu_scoller = Content.Load<SoundEffect>("sounds/menu_scoller2");
            defense = Content.Load<SoundEffect>("sounds/defense");
            intern_sound = Content.Load<SoundEffect>("sounds/intern_sound");

              
        }
        public static void playSound(int x)
        {
            if (x == 1)
                item_found.Play();
            else if (x == 2)
                before_boss.Play();
            else if (x == 3)
                hp_up.Play();
            else if (x == 4)
                item_not_found.Play();
            else if (x == 5)
                enemy_destroyed.Play();
            else if (x == 6)
                hit.Play();//need louder hit sound
            else if (x == 7)
                menu_scoller.Play();//<--Keyboard, Pause_menu, Submenu,  ...just put it everywhere
            else if (x == 8)
                defense.Play();
            else if (x == 9) 
                intern_sound.Play();


        }
        
        public static void playsong()
        {
           // MediaPlayer.Play(song);
            song2.IsLooped = true;
            //song2.Pitch = 0.9f;
            song2.Volume = .40f;
            song2.Play();
        }
        
        public static void stopsongtitle()
        {
            //MediaPlayer.Stop(song);
            //song2.IsLooped = true;
            //song2.Pitch = 0.9f;
            //song2.Volume = 1;
            //song2.Play();
            song2.Stop();



        }
    }
}