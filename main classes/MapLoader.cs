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
    public class MapLoader
    {
        
      
    public static void LoadContent(ContentManager Content)
    {
        Map1.LoadContent(Content);
        Map.LoadContent(Content);
        Map3.LoadContent(Content);
        Map4.LoadContent(Content);
        Map5.LoadContent(Content);
        Map6.LoadContent(Content);
        Map7.LoadContent(Content);
    }
    public static void Update(GameTime gameTime, Rectangle clientBounds,int mapNuber)
    {
        if (mapNuber == 1)
        {
            Map1.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 2)
        {
            Map.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 3)
        {
            Map3.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 4)
        {
            Map4.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 5)
        {
            Map5.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 6)
        {
            Map6.Update(gameTime, clientBounds);
        }
        else if (mapNuber == 7)
        {
            Map7.Update(gameTime, clientBounds);
        }
    }
    public static void Draw(GameTime gameTime, SpriteBatch spriteBatch, int mapNuber)
    {
        if (mapNuber == 1)
        {

            Map1.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 2)
        {
            Map.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 3)
        {
            Map3.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 4)
        {
            Map4.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 5)
        {
            Map5.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 6)
        {
            Map6.Draw(gameTime, spriteBatch);
        }
        else if (mapNuber == 7)
        {
            Map7.Draw(gameTime, spriteBatch);
        } 
	}
    }
}
