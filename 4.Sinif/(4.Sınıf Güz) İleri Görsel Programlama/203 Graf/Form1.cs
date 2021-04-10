using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        readonly Random rnd = new Random();
        const int n = 100, a = 50;
        Point[] p;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Hesapla()
        {
            if (p == null) p = new Point[n];
            for (int i = 0; i < p.Length; i++)
            {
                p[i].X = rnd.Next(0, pBox.Width - a);
                p[i].Y = rnd.Next(0, pBox.Height - a);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
            Hesapla();
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            Hesapla();
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Green);
            Pen klm = new Pen(Color.Red, 3);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < n; i++)
            {
                grf.FillEllipse(boya, p[i].X, p[i].Y, a, a);
                grf.DrawEllipse(klm, p[i].X, p[i].Y, a, a);
            }
            boya.Dispose();
            klm.Dispose();
        }
    }
}