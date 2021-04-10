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

        bool okey;
        int m, n;
        Bitmap bmp;
        OpenFileDialog ofd = new OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.Filter = "Resim  Dosyaları|*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            pBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pBox1.Left = 0;
            pBox1.Top = 0;
            panel1.AutoScroll = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBox1.Image = null;
                pBox2.Image = null;
                try
                {
                    pBox1.Image = Image.FromFile(ofd.FileName);
                    bmp = new Bitmap(pBox1.Image);
                    m = bmp.Width;
                    n = bmp.Height;
                    Text = string.Format("Resim Boyutları : {0}x{1}", m, n);
                    okey = true;
                }
                catch
                {
                    MessageBox.Show(ofd.FileName + " geçerli resim dosyası değil");
                    Text = "Hasan Temurtaş";
                    okey = false;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (okey)
            {
                button2.Enabled = false;
                pBox2.Image = bmp;
                button2.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (okey)
            {
                button3.Enabled = false;
                int i, j, k;
                Bitmap hsn = new Bitmap(m, n);
                Color c;
                for (i = 0; i < m; i++)
                    for (j = 0; j < n; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        k = (byte)Math.Round(0.28 * c.R + 0.57 * c.G + 0.15 * c.B);
                        c = Color.FromArgb(c.A, k, k, k);
                        hsn.SetPixel(i, j, c);
                    }
                pBox2.Image = hsn;
                button3.Enabled = true;
            }
        }
    }
}