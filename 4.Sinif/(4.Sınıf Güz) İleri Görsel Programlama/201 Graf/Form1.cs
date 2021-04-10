using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        Point[] a;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Hesapla()
        {
            int n, N = 251;
            float t, f = 3;
            if (a == null) a = new Point[N];
            for (n = 0; n < N; n++)
            {
                t = (float)n / (N - 1);
                a[n].X = (int)(pBox.Width * t);
                a[n].Y = (int)(pBox.Height *
                    (0.5 - 0.45 * Math.Sin(2 * Math.PI * f * t)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
        }

        private void PBox_Resize(object sender, EventArgs e)
        {
            Hesapla();
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            Pen klm = new Pen(Color.Red, 3);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.DrawLines(klm, a);
            klm.Dispose();
        }
    }
}