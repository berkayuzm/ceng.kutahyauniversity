using System;
using System.Drawing;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp, bmp2;
        Color c;
        int m, n;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Image);
            m = bmp.Width;
            n = bmp.Height;
            bmp2 = new Bitmap(m, n);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    c = bmp.GetPixel(i, j);
                    c = Color.FromArgb(c.A, (byte)~c.R, (byte)~c.G, (byte)~c.B);
                    bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bmp;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int i, j;
            byte k;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    c = bmp.GetPixel(i, j);
                    k = (byte)Math.Round((c.R + c.G + c.B) / 3.0);
                    c = Color.FromArgb(c.A, k, k, k);
                    bmp2.SetPixel(i, j, c);
                }
            pictureBox2.Image = bmp2;
        }
    }
}