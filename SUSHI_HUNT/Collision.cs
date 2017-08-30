using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSHI_HUNT
{
    class Collision
    {
        private int a, b, hypotenuse;

        public bool is_Inside_Sprite(sprite sushi, sprite character)
        {
            if ((sushi.position.X >= character.position.X) &&
                    (sushi.Right() <= character.Right()) &&
                    (sushi.position.Y >= character.position.Y) &&
                    (sushi.Bottom() <= character.Bottom()))
                
                //if dimensions of character are inside sushi
            {
                return true; //collision is true
            }
            else
            {
                return false; //collision is false
            }
        }

        public bool Collided_with_sprite(sprite character, sprite sushi)
        {
            a = Math.Abs(character.CentreX() - sushi.CentreX());
            b = Math.Abs(character.CentreY() - sushi.CentreY());

            hypotenuse = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            if ((hypotenuse <= (character.width + sushi.width) / 2) ||
                (hypotenuse <= (character.height + sushi.height) / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
