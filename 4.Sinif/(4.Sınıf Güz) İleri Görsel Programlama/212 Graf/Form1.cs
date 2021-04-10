using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        const int r = 75;
        float x, y, mx, my;

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
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            float V = 5, xL = mx - x, yL = my - y;
            float L = (float)Math.Sqrt(Math.Pow(xL, 2) + Math.Pow(yL, 2));
            if (L <= V)
            {
                x = mx;
                y = my;
            }
            else
            {
                x += V * xL / L;
                y += V * yL / L;
            }
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Blue);
            Pen klm = new Pen(Color.Red, 9);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillEllipse(boya, x - r, y - r, 2 * r, 2 * r);
            grf.DrawEllipse(klm, x - r, y - r, 2 * r, 2 * r);
            boya.Dispose();
            klm.Dispose();
        }
    }
}