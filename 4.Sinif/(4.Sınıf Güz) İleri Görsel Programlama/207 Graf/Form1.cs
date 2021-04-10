using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        float mx, my, x, y, a, b;

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

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            x = pBox.Width / 2f;
            y = pBox.Height / 2f;
            a = (float)((mx - x) * Math.Sqrt(2));
            b = (float)((my - y) * Math.Sqrt(2));
            pBox.Invalidate();
            //pBox.Refresh();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.White);
            Pen klm = new Pen(Color.Blue, 9);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillEllipse(boya, x - a, y - b, 2 * a, 2 * b);
            grf.DrawEllipse(klm, x - a, y - b, 2 * a, 2 * b);
            boya.Dispose();
            klm.Dispose();
        }
    }
}