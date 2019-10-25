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
        //speed, move function
        public Ball(Texture2D image, Vector2 position, Color tint) 
            : base(image, position, tint)
        {
        }
    }
}
