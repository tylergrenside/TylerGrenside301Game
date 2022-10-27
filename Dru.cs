using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TylerGrenside301Game
{
    // declare fields to use in the class
    public int x, y, width, height;//variables for the rectangle
    public Image druImage;//variable for the planet's image

    public Rectangle drutRec;//variable for a rectangle to place our image in
    public int score;
    //Create a constructor (initialises the values of the fields)

    class Dru
    {
        x = 10;
            y = 10;
            width = 20;
            height = 20;
	//planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);
    }
}
