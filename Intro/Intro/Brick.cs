using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Intro
{

    public class Brick : Sprite
    {
          public enum powerUps
        {
            WiderPaddle,
            FasterBall,
            MoreBalls
        };

        public string name = "Brick";
        public bool doIHavePowerUp;
        public powerUps powerUp;
        public bool visible;
        public Brick(Texture2D image, Vector2 position, Color tint) : base(image, position, tint)
        {
            visible = true;
        }

        public bool hasPowerUp()
        {
            if(doIHavePowerUp)
            {
                return true;
            }
            return false;
        }
    }
}
