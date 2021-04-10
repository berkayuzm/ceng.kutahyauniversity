using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ImageCodecInfo FindCodec(ImageFormat format)
        {
            ImageCodecInfo[] Codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo Codec in Codecs)
                if (Codec.FormatID == format.Guid) return Codec;
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            panel1.AutoScroll = true;
            openFileDialog1.Filter = "Resim Files|*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show(openFileDialog1.FileName + " Geçersiz Resim Dosyası");
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg File|*.jpg";
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.FileName = "Resim.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                long Kalite = (long)numericUpDown1.Value;
                EncoderParameters EnParams = new EncoderParameters(2);
                EnParams.Param[0] = new EncoderParameter(Encoder.Quality, Kalite);
                if (radioButton1.Checked)
                    EnParams.Param[1] = new EncoderParameter(
                        Encoder.RenderMethod, (byte)EncoderValue.RenderProgressive);
                else
                    EnParams.Param[1] = new EncoderParameter(
                        Encoder.RenderMethod, (byte)EncoderValue.RenderNonProgressive);
                ImageCodecInfo Codec = FindCodec(ImageFormat.Jpeg);
                pictureBox1.Image.Save(saveFileDialog1.FileName, Codec, EnParams);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Bmp File|*.bmp";
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.FileName = "Resim.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EncoderParameters EnParams = new EncoderParameters(1);
                if (radioButton3.Checked)
                    EnParams.Param[0] = new EncoderParameter(
                        Encoder.Compression, (byte)EncoderValue.CompressionNone);
                else
                    EnParams.Param[0] = new EncoderParameter(
                        Encoder.RenderMethod, (byte)EncoderValue.CompressionRle);
                ImageCodecInfo Codec = FindCodec(ImageFormat.Bmp);
                pictureBox1.Image.Save(saveFileDialog1.FileName, Codec, EnParams);
            }
        }
    }
}