using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        int w, h, n;

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            button1.Size = new Size(85, 65);
            w = ClientSize.Width - button1.Width;
            h = ClientSize.Height - button1.Height;
            button1.Left = rnd.Next(0, w);
            button1.Top = rnd.Next(0, h);
            timer1.Interval = 50;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Text = "Say = " + (++n).ToString("D3");
            int x, y, xi, xf, yi, yf;
            xi = button1.Left - button1.Width;
            xf = button1.Left + button1.Width;
            yi = button1.Top - button1.Height;
            yf = button1.Top + button1.Height;
            while (true)
            {
                x = rnd.Next(0, w);
                y = rnd.Next(0, h);
                if (x < xi || x > xf || y < yi || y > yf) break;
            }
            button1.Left = x;
            button1.Top = y;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Tebrikler", "Bilgi");
            n = 0;
        }
    }
}