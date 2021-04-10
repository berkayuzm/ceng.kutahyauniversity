using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        int m;
        const int N = 100, M = 240, r = 25;
        Point[] p = new Point[N];

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            double t, f = 2.5;
            double q = 2 * Math.PI * m / M;
            m = (m + 1) % M;
            double w = pBox.Width - 2 * r;
            double h = pBox.Height - 2 * r;
            for (int n = 0; n < N; n++)
            {
                t = (double)n / (N - 1);
                p[n].X = (int)(w * t);
                p[n].Y = (int)(h *
                    (1 + Math.Sin(q + 2 * Math.PI * f * t)) / 2);
            }
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Red);
            Pen klm = new Pen(Color.Blue, 3);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            for (int n = 0; n < N; n++)
            {
                grf.FillEllipse(boya, p[n].X, p[n].Y, 2 * r, 2 * r);
                grf.DrawEllipse(klm, p[n].X, p[n].Y, 2 * r, 2 * r);
            }
            boya.Dispose();
            klm.Dispose();
        }
    }
}