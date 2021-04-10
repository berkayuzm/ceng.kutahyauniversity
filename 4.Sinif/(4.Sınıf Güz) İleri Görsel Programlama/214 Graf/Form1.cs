using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        bool durum;
        float x, y, mx, my, k = 9;
        const int w = 150, h = 100;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
            x = (ClientSize.Width-w) / 2f;
            y = (ClientSize.Height-h) / 2f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mx > x - 5 && mx < x + w + 5 &&
                my > y - 5 && my < y + h + 5)
            {
                k = 15;
                if (durum)
                {
                    x += e.X - mx;
                    y += e.Y - my;
                }
            }
            else k = 9;
            mx = e.X;
            my = e.Y;
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Green);
            Pen klm = new Pen(Color.Red, k);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillRectangle(boya, x, y, w, h);
            grf.DrawRectangle(klm, x, y, w, h);
            boya.Dispose();
            klm.Dispose();
        }
    }
}