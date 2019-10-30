using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Intro
{
    class Brick : Sprite
    {
        public string name = "Brick";
        public Brick(Texture2D image, Vector2 position, Color tint) : base(image, position, tint)
        {
        }
    }
}
