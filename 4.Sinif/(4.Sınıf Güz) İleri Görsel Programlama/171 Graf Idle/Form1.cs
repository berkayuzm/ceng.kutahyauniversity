using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        Random rnd;
        Bitmap bmp;
        Graphics grf;
        int n;
        bool durum;

        private Color SeçRasgeleRenk()
        {
            int r = rnd.Next(0, 256);
            int g = rnd.Next(0, 256);
            int b = rnd.Next(0, 256);
            return Color.FromArgb(100, r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            pBox.Dock = DockStyle.Fill;
            pBox.BackColor = Color.Aqua;
            pBox.SizeMode = PictureBoxSizeMode.CenterImage;
            bmp = new Bitmap(700, 500);
            pBox.Image = bmp;
            grf = Graphics.FromImage(bmp);
            grf.Clear(Color.White);
            grf.SmoothingMode = SmoothingMode.AntiAlias;
            Application.Idle += new EventHandler(IdleEvent);
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        void IdleEvent(object sender, EventArgs e)
        {
            if (durum)
            {
                n = 0;
                grf.Clear(Color.White);
            }
            else
            {
                n++;
                int a = rnd.Next(50, 101);
                int x = rnd.Next(0, bmp.Width - a);
                int y = rnd.Next(0, bmp.Height - a);
                SolidBrush boya = new SolidBrush(SeçRasgeleRenk());
                grf.FillEllipse(boya, x, y, a, a);
                boya.Dispose();
            }
            Text = "Daire Sayısı : " + n.ToString();
            pBox.Invalidate();
            //pBox.Refresh();
        }
    }
}