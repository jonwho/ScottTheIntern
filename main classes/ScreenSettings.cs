using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ScottTheIntern
{
    // Handle preferred screen settings.
    class ScreenSettings
    {
        public static void screenstings(GraphicsDeviceManager graphics)
        {
            KeyboardState kb = Keyboard.GetState() ;
            if (kb.IsKeyDown(Keys.F11))
            {
                    graphics.ToggleFullScreen();
            }
        }
    }
}
