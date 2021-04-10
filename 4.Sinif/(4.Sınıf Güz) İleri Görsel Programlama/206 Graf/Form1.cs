using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        readonly Random rnd = new Random();
        const int N = 12;
        Color[] aRenk;

        void RastgeleRenkler()
        {
            int r, g, b;
            if (aRenk == null) aRenk = new Color[N];
            for (int n = 0; n < N; n++)
            {
                r = rnd.Next(256);
                g = rnd.Next(256);
                b = rnd.Next(256);
                aRenk[n] = Color.FromArgb(r, g, b);
            }
        }

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.Dock = DockStyle.Fill;
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
            Rectangle rec = new Rectangle(0, 0, pBox.Width, pBox.Height);
            SolidBrush boya = new SolidBrush(Color.White);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            float q = 0, dq = 360f / N;
            for (int n = 0; n < N; n++)
            {
                boya.Color = aRenk[n];
                grf.FillPie(boya, rec, q, dq);
                q += dq;
            }
            boya.Dispose();
        }
    }
}