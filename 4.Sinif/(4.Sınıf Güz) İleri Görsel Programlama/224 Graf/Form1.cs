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

        int mx, my;
        bool durum;
        SolidBrush boya;
        Pen klm;

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Blue;
            pBox.Dock = DockStyle.Fill;
            boya = new SolidBrush(Color.Red);
            klm = new Pen(Color.Green, 3);
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        private void Çiz(Graphics grf, float x, float y, float a, float b, int i, int n)
        {
            int c = 255 - 200 * i / n;
            if (durum) {
                klm.Color = Color.Green;
                boya.Color = Color.FromArgb(c, 0, 0);
            } else {
                klm.Color = Color.Red;
                boya.Color = Color.FromArgb(0, c, 0);
            }
            
            grf.FillEllipse(boya, x - a / 2, y - b / 2, a, b);
            grf.DrawEllipse(klm, x - a / 2, y - b / 2, a, b);
            if (++i > n) return;
            Çiz(grf, x - a / 4, y, a / 2, b / 2, i, n);
            Çiz(grf, x + a / 4, y, a / 2, b / 2, i, n);
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            float a = 400, b = 300;
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            Çiz(grf, mx, my, a, b, 0, 4);
        }
    }
}
