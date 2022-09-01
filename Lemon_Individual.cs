using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TylerGrenside301Game
{
    class Lemon_Individual
    {
        public int x, y, width, height;//variables for the rectangle
        public Image lemon;//variable for the spaceship's image
        public Rectangle lemRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Lemon_Individual()
        {
            x = 600;
            y = 300;
            width = 80;
            height = 85;
            lemon = Properties.Resources.Lemon_Individual;
            lemRec = new Rectangle(x, y, width, height);
        }

        public void drawlemon(Graphics g)
        {
            g.DrawImage(lemon, lemRec);
        }
    }
}
