using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace TylerGrenside301Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Slime slime = new Slime();//create object called slime 
        Lemon_Individual lemon = new Lemon_Individual();//create object called lemon
        bool left, right;
        string move;

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrSlime.Enabled = true;
        }


 

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            slime.drawSlime(g);
            lemon.drawlemon(g);
            this.Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
          

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }

        }



        private void tmrSlime_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {

                move = "right";
                slime.MoveSlime(move);
            }
            if (left) // if left arrow key pressed
            {

                move = "left";
                slime.MoveSlime(move);
            }

            pnlGame.Invalidate();
            if (slime.slimeRec.IntersectsWith(lemon[i].lemonRec))
            {
                //reset planet[i] back to top of panel
                slime[i].x = 30; // set  y value of planetRec
            }

        }
   
    }
}