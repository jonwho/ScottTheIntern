using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScottTheIntern
{
    class Modifier2DBlood : Modifier2D
    {
        /* to do:
         * get sprite origin
         * put emitter at desired x,y location
         * put in correct velocity vectors to represent where we want the particle to fly
         */
        protected float m_blood = 200.0f;

        public Modifier2DBlood() { }
        public Modifier2DBlood(float blood)
        {
            m_blood = blood;
        }

        public override void Update(Particle2D particle, float elapsed)
        {
            Vector2 v2 = particle.Speed;
            v2.X += m_blood * elapsed;
        }
    }
}
