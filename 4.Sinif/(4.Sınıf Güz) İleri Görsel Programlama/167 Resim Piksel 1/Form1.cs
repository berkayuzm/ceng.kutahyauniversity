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
            ClientSize = new Size(800, 600);
        }

        Bitmap bmp1, bmp2;
        const int N = 8;
        int n = N - 1; 

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp1 = new Bitmap("../../../Pictures/Rsm01.jpg");
            bmp2 = new Bitmap(bmp1.Width, bmp1.Height);
            tmr.Interval = 1000;
            tmr.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Tmr_Tick(sender, e);
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Color rnk;
            int i, j, k;
            n = (n + 1) % N;
            for (i = 0; i < bmp1.Width; i++)
                for (j = 0; j < bmp1.Height; j++)
                {
                    rnk = bmp1.GetPixel(i, j);
                    k = (int)Math.Round(0.299 * rnk.R + 0.587 * rnk.G + 0.114 * rnk.B);
                    switch (n)
                    {
                        case 1: rnk = Color.FromArgb(k, 0, 0); break;
                        case 2: rnk = Color.FromArgb(0, k, 0); break;
                        case 3: rnk = Color.FromArgb(0, 0, k); break;
                        case 4: rnk = Color.FromArgb(k, k, 0); break;
                        case 5: rnk = Color.FromArgb(k, 0, k); break;
                        case 6: rnk = Color.FromArgb(0, k, k); break;
                        case 7: rnk = Color.FromArgb(k, k, k); break;
                    }
                    bmp2.SetPixel(i, j, rnk);
                }
            Invalidate();
            Text = "Karışım = " + n.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            int x = (ClientSize.Width - bmp1.Width) / 2;
            int y = (ClientSize.Height - bmp1.Height) / 2;
            grf.DrawImage(bmp2, x, y);
        }
    }
}