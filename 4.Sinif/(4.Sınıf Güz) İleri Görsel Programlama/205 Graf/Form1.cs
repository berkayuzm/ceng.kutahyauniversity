using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        int mx, my;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            pBox.Invalidate();
        }

        private void PBox_Resize(object sender, EventArgs e)
        {
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            double cx = pBox.Width / 2d;
            double cy = pBox.Height / 2d;
            double q = Math.Atan2(my - cy, mx - cx);
            double d = Math.Sqrt(Math.Pow(mx - cx, 2) + Math.Pow(my - cy, 2));
            int x, y, a = 50, N = (int)Math.Ceiling(0.3 + d / a);
            Pen klm = new Pen(Color.Red, 3);
            SolidBrush boya = new SolidBrush(Color.Green);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            for (int n = 0; n < N; n++)
            {
                x = (int)(cx - a / 2d + n * a * Math.Cos(q));
                y = (int)(cy - a / 2d + n * a * Math.Sin(q));
                grf.FillEllipse(boya, x, y, a, a);
                grf.DrawEllipse(klm, x, y, a, a);
            }
            boya.Dispose();
            klm.Dispose();
        }
    }
}