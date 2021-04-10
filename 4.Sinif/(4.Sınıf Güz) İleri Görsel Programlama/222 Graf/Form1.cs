using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.FileName = "Resim";
            ofd.DefaultExt = "jpg";
            ofd.Filter = "PNG Files|*.png|JPG Files|*.jpg|BMP Files|*.bmp";
            ofd.Title = "Lütfen Bir Resim Dosyası Seçin";
            //ofd.InitialDirectory = "E:";
            sfd.FileName = "Resim";
            sfd.DefaultExt = "png";
            sfd.Filter = "PNG Files|*.png|JPG Files|*.jpg|BMP Files|*.bmp|"
                       + "GIF Files|*.gif|Icon Files|*.ico|TIFF Files|*.tiff";
            sfd.Title = "Kaydetme Penceresi";
            //sfd.InitialDirectory = "E:";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                pBox.Image = new Bitmap(ofd.OpenFile());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat Format;
                switch (Path.GetExtension(sfd.FileName))
                {
                    case "png": Format = ImageFormat.Png; break;
                    case "jpg": Format = ImageFormat.Jpeg; break;
                    case "bmp": Format = ImageFormat.Bmp; break;
                    case "gif": Format = ImageFormat.Gif; break;
                    case "ico": Format = ImageFormat.Icon; break;
                    default: Format = ImageFormat.Tiff; break;
                }
                pBox.Image.Save(sfd.FileName, Format);
            }
        }
    }
}