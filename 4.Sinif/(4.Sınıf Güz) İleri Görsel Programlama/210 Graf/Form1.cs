using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        bool durum;
        int mx, my, n;
        const int N = 180, M = 10;
        Point[] p = new Point[M];

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Red;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 1;
            tmr.Enabled = true;
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
            mx = e.X;
            my = e.Y;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            double r, q = 2 * Math.PI * n / N;
            n = (n + 1) % N;
            for (int m = 0; m < M; m++)
            {
                if (m % 2 == 0) r = 120; else r = 50;
                p[m].X = (int)(mx + r * Math.Cos(q));
                p[m].Y = (int)(my + r * Math.Sin(q));
                q += 2 * Math.PI / M;
            }
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.White);
            Pen klm = new Pen(Color.Blue, 9);
            if (durum)
            {
                boya.Color = Color.Blue;
                klm.Color = Color.White;
            }
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillPolygon(boya, p);
            grf.DrawPolygon(klm, p);
            boya.Dispose();
            klm.Dispose();
        }
    }
}