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
               
                 if (slimeRec.Location.X > 625) // is slime within 625 of right side
                 {
                  
                    x = 630;
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
                 if (slimeRec.Location.X < 5) // is slime within 5 of left side
                 {
                     x = 0;
                     slimeRec.Location = new Point(x, y);
                 }
                 else
                 {
                     x -= 5;
                     slimeRec.Location = new Point(x, y);
                 }

             }

            if (move == "up")
            {
                if (slimeRec.Location.Y < 0) // is slime within 5 of top side
                {
                    y = -5;
                    slimeRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 5;
                    slimeRec.Location = new Point(x, y);
                }

            }
          
            if (move == "down")
            {
                if (slimeRec.Location.Y > 350) // is slime within 5 of bottom side
                {
                    y = 360;
                    slimeRec.Location = new Point(x, y);
                }
                else
                {
                    y += 5;
                    slimeRec.Location = new Point(x, y);
                }

            }

        }

    }
}