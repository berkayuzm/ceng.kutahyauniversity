using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        const int r = 50;
        float x, y, vx, vy;

        private void PBox_MouseClick(object sender, MouseEventArgs e)
        {
            vx = (e.X - x - r) / 25;
            vy = (e.Y - y - r) / 25;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) vx += 1;
            else if (e.KeyCode == Keys.Left) vx -= 1;
            else if (e.KeyCode == Keys.Down) vy += 1;
            else if (e.KeyCode == Keys.Up) vy -= 1;
        }

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = ClientSize.Width / 2f - r;
            y = ClientSize.Height / 2f - r;
            pBox.BackColor = Color.Yellow;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            x += vx;
            y += vy;
            if (x < 0 || x > ClientSize.Width - 2 * r) vx *= -1;
            if (y < 0 || y > ClientSize.Height - 2 * r) vy *= -1;
            Text = string.Format("Vx : {0}, Vy : {1}", vx, vy);
            pBox.Invalidate();
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Red);
            Pen klm = new Pen(Color.Green, 9);
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            grf.FillEllipse(boya, x, y, 2 * r, 2 * r);
            grf.DrawEllipse(klm, x, y, 2 * r, 2 * r);
            boya.Dispose();
            klm.Dispose();
        }
    }
}