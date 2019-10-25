﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Sprite
    {

        public Texture2D image;
        public Vector2 position;
        Color tint;
        public Rectangle hitbox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
            }
        }
        
        public Sprite(Texture2D image, Vector2 position, Color tint)
        {
            this.image = image;
            this.position = position;
            this.tint = tint;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image,position,tint);
        }
        

    }
}
