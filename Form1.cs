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
        List<Dru> dru = new List <Dru>();
        bool left, right, up, down;
        string move;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                dru.Add(new Dru(displacement));
            }

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrSlime.Enabled = true;
        }


 

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {

            foreach (Dru p in dru)
            {
                p.DrawDru(g);//Draw the planet
                p.moveDru(g);//move the planet
            }

            g = e.Graphics;
            
            slime.drawSlime(g);
            
            this.Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
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
            if (up) // if up arrow key pressed
            {

                move = "up";
                slime.MoveSlime(move);
            }
            if (down) // if down arrow key pressed
            {

                move = "down";
                slime.MoveSlime(move);
            }
            pnlGame.Invalidate();
            for (int i =0; i<1; i++)
            { 
            
            }
        }
   
    }
}