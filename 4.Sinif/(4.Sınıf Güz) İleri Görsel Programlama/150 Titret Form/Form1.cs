using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd;

        Color SecRasgeleRenk()
        {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BackColor = SecRasgeleRenk();
            Text = String.Format("{0} ---> {1:X8}",
                BackColor, BackColor.ToArgb());
            Point p = Location;
            Point q = p;
            for (int i = 0; i < 40; i++)
            {
                q.X += rnd.Next(-25, 26);
                q.Y += rnd.Next(-25, 26);
                Location = q;
                Thread.Sleep(50);
            }
            Location = p;
        }
    }
}