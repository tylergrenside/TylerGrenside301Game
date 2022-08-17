using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TylerGrenside301Game
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Slime slime = new Slime();//create object called spaceship 
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tmrMoveEvent(object sender, EventArgs e)
        {

        }

        private void cab_Click(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            slime.drawSlime(g);

        }
    }
}
