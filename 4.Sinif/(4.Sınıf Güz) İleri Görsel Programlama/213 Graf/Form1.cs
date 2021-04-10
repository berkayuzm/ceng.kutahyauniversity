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
        const int r = 75;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
            x = ClientSize.Width / 2f;
            y = ClientSize.Height / 2f;
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
            double L = Math.Sqrt(Math.Pow(mx - x, 2) + Math.Pow(my - y, 2));
            if (L < r + 5)
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
            grf.FillEllipse(boya, x - r, y - r, 2 * r, 2 * r);
            grf.DrawEllipse(klm, x - r, y - r, 2 * r, 2 * r);
            boya.Dispose();
            klm.Dispose();
        }
    }
}