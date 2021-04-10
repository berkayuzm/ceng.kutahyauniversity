using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        readonly Random rnd = new Random();
        const int M = 7, N = 9;
        Color[] aRenk;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        void RastgeleRenkler()
        {
            int r, g, b;
            if (aRenk == null) aRenk = new Color[M * N];
            for (int k = 0; k < aRenk.Length; k++)
            {
                r = rnd.Next(256);
                g = rnd.Next(256);
                b = rnd.Next(256);
                aRenk[k] = Color.FromArgb(r, g, b);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.Dock = DockStyle.Fill;
            pBox.BackColor = Color.White;
            RastgeleRenkler();
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            RastgeleRenkler();
            pBox.Invalidate();
        }

        private void PBox_Resize(object sender, EventArgs e)
        {
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            float x, w = (float)pBox.Width / N;
            float y, h = (float)pBox.Height / M;
            SolidBrush boya = new SolidBrush(Color.Black);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            for (int k = 0; k < aRenk.Length; k++)
            {
                x = (k % N) * w;
                y = (k / N) * h;
                boya.Color = aRenk[k];
                grf.FillEllipse(boya, x, y, w, h);
            }
            boya.Dispose();
        }
    }
}