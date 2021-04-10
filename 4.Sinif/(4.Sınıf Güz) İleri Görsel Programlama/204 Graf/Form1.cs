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
            int a = 50, x = pBox.Width / 2, y = pBox.Height / 2;
            SolidBrush boya = new SolidBrush(Color.Red);
            Pen klm = new Pen(Color.Red, a);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            for(int i = 0; i < 2; i++)
            {
                if (i > 0)
                {
                    a = 30;
                    klm.Width = a;
                    klm.Color = Color.Green;
                    boya.Color = Color.Green;
                }
                grf.FillEllipse(boya, x - a / 2, y - a / 2, a, a);
                grf.FillEllipse(boya, mx - a / 2, my - a / 2, a, a);
                grf.DrawLine(klm, x, y, mx, my);
            }
            klm.Dispose();
            boya.Dispose();
        }
    }
}