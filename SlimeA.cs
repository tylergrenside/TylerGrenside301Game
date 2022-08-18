using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;



namespace TylerGrenside301Game
{
    class Slime
    {
        public int x, y, width, height;//variables for the rectangle
        public Image slime;//variable for the spaceship's image
       

        public Rectangle slimeRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Slime()
        {
            x = 10;
            y = 350;
            width = 73;
            height = 39;
            slime = Properties.Resources.Cabbage_Lad3;
            slimeRec = new Rectangle(x, y, width, height);
        }

        public void drawSlime(Graphics g)
        {
            g.DrawImage(slime, slimeRec);
        }

      
        public void MoveSlime(string move)
        {
            slimeRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (slimeRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    slimeRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    slimeRec.Location = new Point(x, y);
                }

            }


            if (move == "left")
            {
                if (slimeRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    slimeRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    slimeRec.Location = new Point(x, y);
                }

            }



        }

    }
}

