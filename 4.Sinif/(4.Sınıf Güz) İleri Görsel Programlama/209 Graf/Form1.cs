using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        const float r = 75;
        float x = 400, y = 300, vx = 3, vy = 4;
        
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

        private void Tmr_Tick(object sender, EventArgs e)
        {
            x += vx;
            y += vy;
            if (x <= r || x >= pBox.Width - r) vx = -vx;
            if (y <= r || y >= pBox.Height - r) vy = -vy;
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.White);
            Pen klm = new Pen(Color.Blue, 10);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillEllipse(boya, x - r, y - r, 2 * r, 2 * r);
            grf.DrawEllipse(klm, x - r, y - r, 2 * r, 2 * r);
            boya.Dispose();
            klm.Dispose();
        }
    }
}