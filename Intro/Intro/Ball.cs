using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Intro
{
    class Ball : Sprite
    {
        Vector2 speeds;
        bool hitBottom;
        Vector2 defaultPosition;
        public Ball(Texture2D image, Vector2 position, Color tint) 
            : base(image, position, tint)
        {
            speeds.X = 1;
            speeds.Y = 1;
            defaultPosition = position;
        }
        public void flipSpeed()
        {
            this.speeds.X *= -1;
            this.speeds.Y *= -1;
        }
        void giveSpeed()
        {

            position.X += speeds.X;
            position.Y += speeds.Y;
        }
        void bottomScreenReset()
        {
            if (hitBottom)
            {
                position = defaultPosition;
                hitBottom = false;
            }
           
        }
        public void move(Viewport walls)
        {
            giveSpeed();
            if (position.X < 0 || position.X + image.Width > walls.Width)
            {
                speeds.X *= -1;
            }
            if (position.Y < 0)
            {
                speeds.Y *= -1;
                
            }
            if(position.Y + image.Height > walls.Height)
            {
                hitBottom = true;
            }
            bottomScreenReset();
        }
      
        
    }
}
