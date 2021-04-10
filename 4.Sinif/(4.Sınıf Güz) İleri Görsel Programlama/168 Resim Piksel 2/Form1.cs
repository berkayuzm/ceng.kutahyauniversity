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
            bmp = new Bitmap("../../../Pictures/Rsm00.jpg");
            pBox.Image = bmp;
            pBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Fare: {0:D3} : {1:D3}", e.X, e.Y);
            Color rnk = bmp.GetPixel(e.X, e.Y);
            label1.Text = rnk.A.ToString();
            label2.Text = rnk.R.ToString();
            label3.Text = rnk.G.ToString();
            label4.Text = rnk.B.ToString();
            //bmp.SetPixel(e.X, e.Y, Color.Black);
            //pBox.Refresh();
        }
    }
}