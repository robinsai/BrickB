using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    //move function that takes in keys
    class Paddle : Sprite
    {
   
        public Paddle(Texture2D image, Vector2 position, Color tint) 
            : base(image, position, tint)
        {
        }
    }
}
