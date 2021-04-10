using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        const int r = 50, N = 180;
        float x, y, a, b;
        int n;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            double q = 2 * Math.PI * n / N;
            n = (n + 1) % N;
            a = pBox.Width / 2f - r;
            b = pBox.Height / 2f - r;
            x = (float)(a * (1 + Math.Cos(q)));
            y = (float)(b * (1 + Math.Sin(q)));
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Red);
            Pen klm = new Pen(Color.Blue, 10);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.DrawEllipse(klm, r, r, 2 * a, 2 * b);
            grf.FillEllipse(boya, x, y, 2 * r, 2 * r);
            boya.Dispose();
            klm.Dispose();
        }
    }
}