using System;
using System.Drawing;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int x, y, k, bw, bh, pw, ph, a = 300;

        public Form1()
        {
            InitializeComponent();
            pBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap("../../../Pictures/Resim.jpg");
            pBox1.Image = bmp;
            bw = bmp.Width;
            bh = bmp.Height;
            pw = pBox1.Width;
            ph = pBox1.Height;
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void PBox1_MouseLeave(object sender, EventArgs e)
        {
            k = 2;
        }

        private void PBox1_MouseMove(object sender, MouseEventArgs e)
        {
            k = 1;
            x = e.X;
            y = e.Y;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (k == 1) {
                x = x * bw / pw - a / 2;
                y = y * bh / ph - a / 2;
                if (x < 0) x = 0; else if (x > bw - a) x = bw - a;
                if (y < 0) y = 0; else if (y > bh - a) y = bh - a;
                Rectangle rect = new Rectangle(x, y, a, a);
                pBox2.Image = bmp.Clone(rect, bmp.PixelFormat);
            }
            else if (k == 2) pBox2.Image = null;
            k = 0;
        }
    }
}