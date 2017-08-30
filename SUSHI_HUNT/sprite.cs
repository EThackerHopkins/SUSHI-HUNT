using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSHI_HUNT
{
    class sprite
    {
        public Point position; //Position of image; contains x and y
        public int width; //Width of image
        public int height; //Height of image

        public sprite(string myLocation, Point myPosition, int myHeight, int myWidth) //Creation; sets attributes
        {
            position = myPosition;
            width = myWidth;
            height = myHeight;
        }

        //Calculate right edge of image
        public int Right()
        {
            return position.X + width;
        }

        //Calculate the bottom edge of the image
        public int Bottom()
        {
            return position.Y + height;
        }

        //get centre of sprite; x, y

        public int CentreX() 
        {
            return position.X + width / 2;
        }

        public int CentreY()
        {
            return position.Y + height / 2;
        }
    }
}
