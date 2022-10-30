using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TylerGrenside301Game
{
    class Dru
    {

    
    // declare fields to use in the class
    public int x, y, width, height;//variables for the rectangle
    public Image druImage;//variable for the planet's image

    public Rectangle druRec;//variable for a rectangle to place our image in
    public int score;
    //Create a constructor (initialises the values of the fields)
    public Dru(int displacement)
    {
        x = 10;
        y = displacement;
        width = 20;
        height = 20;
        //druImage contains the dru.png image
        druImage = Properties.Resources.Dru;
        druRec = new Rectangle(x, y, width, height);
    }
        // Methods for the enemy's class
        public void DrawDru(Graphics g)
        {
            druRec = new Rectangle(x, y, width, height);

            g.DrawImage(druImage, druRec);
        }
        public void moveDru(Graphics g)
        {
            y += 5;
            druRec.Location = new Point(x, y);

        }


    }
}
