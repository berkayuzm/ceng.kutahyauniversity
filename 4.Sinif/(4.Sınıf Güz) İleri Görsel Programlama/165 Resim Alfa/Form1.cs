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

        Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            //pBox.Image = Image.FromFile("../../../Pictures/Rsm00.jpg");
            pBox.Image = new Bitmap("../../../Pictures/Rsm00.jpg");
            pBox.SizeMode = PictureBoxSizeMode.AutoSize;
            bmp = new Bitmap(pBox.Image);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int k)) {
                if (k < 0) k = 0;
                if (k > 255) k = 255;
            } else k = 255;
            textBox1.Text = k.ToString();
            textBox1.Focus();
            Color rnk;
            int m = bmp.Width, n = bmp.Height;
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    rnk = bmp.GetPixel(i, j);
                    rnk = Color.FromArgb(k, rnk.R, rnk.G, rnk.B);
                    bmp.SetPixel(i, j, rnk);
                }
            pBox.Image = bmp;
        }
    }
}