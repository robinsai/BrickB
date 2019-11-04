using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    //move function that takes in keys
   public class Paddle : Sprite
    {

        
        public Paddle(Texture2D image, Vector2 position, Color tint) 
            : base(image, position, tint)
        {
        }
        public int imageWidth()
        {
            return image.Width;
        }
      
        public void checkButtonPress(KeyboardState ks, Viewport screen)
        {
            
             ks = Keyboard.GetState();
            
            if(ks.IsKeyDown(Keys.Left)&& position.X > 0)
            {
                position.X-=2;
            }
            else if (ks.IsKeyDown(Keys.Right) && position.X + image.Width < screen.Width)
            {
                position.X+=2;
            }


         }
       public void widthModifier(int value)
        {
            image.Width
        }

    }
}
