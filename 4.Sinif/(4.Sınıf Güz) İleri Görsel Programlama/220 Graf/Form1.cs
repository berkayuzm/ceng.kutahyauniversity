using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        SaveFileDialog sfd;
        Graphics grf;
        Bitmap bmp;
        Pen klm;
        Random rnd;
        int mx, my;
        bool ciz;

        public Form1()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
            sfd.FileName = "Resim";
            sfd.DefaultExt = "png";
            sfd.Filter =
                "PNG Files|*.png|JPG Files|*.jpg|BMP Files|*.bmp";
            BackColor = Color.Aqua;
            rnd = new Random();
            klm = new Pen(Color.Black, 5);
        }

        Color RasgeleRenk()
        {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pBox.Width, pBox.Height);
            grf = Graphics.FromImage(bmp);
            grf.Clear(Color.White);
            pBox.Image = bmp;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sfd.Dispose();
            //bmp.Dispose();
            //grf.Dispose();
            //klm.Dispose();
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) ciz = true;
            else klm.Color = RasgeleRenk();
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) ciz = false;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Fare: ({0:D3}, {1:D3}) , Renk : {2:X8}",
                e.X, e.Y, klm.Color.ToArgb());
            if (ciz)
            {
                grf.DrawLine(klm, mx, my, e.X, e.Y);
                pBox.Invalidate();
            }
            mx = e.X;
            my = e.Y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            grf.Clear(Color.White);
            pBox.Invalidate();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat Format;
                switch (Path.GetExtension(sfd.FileName))
                {
                    case ".png": Format = ImageFormat.Png; break;
                    case ".jpg": Format = ImageFormat.Jpeg; break;
                    default: Format = ImageFormat.Bmp; break;
                }
                bmp.Save(sfd.FileName, Format);
            }
        }
    }
}