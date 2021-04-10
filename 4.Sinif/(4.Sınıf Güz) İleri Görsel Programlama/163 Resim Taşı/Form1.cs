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
            ClientSize = new Size(1000, 700);
        }
        
        bool durum;
        int mx, my;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PictureBox[] pBox = new PictureBox[5];
            for (int n = 0; n < pBox.Length; n++)
            {
                Text = string.Format("../../../Pictures/Rsm{0:D2}.jpg", n);
                pBox[n] = new PictureBox {
                    ImageLocation = Text,
                    Location = new Point(rnd.Next(0, 450), rnd.Next(0, 300)),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                };
                pBox[n].MouseDown += new MouseEventHandler(PBox_MouseDown);
                pBox[n].MouseUp += new MouseEventHandler(PBox_MouseUp);
                pBox[n].MouseMove += new MouseEventHandler(PBox_MouseMove);
                Controls.Add(pBox[n]);
            }
        }

        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (sender as PictureBox).BringToFront();
                durum = true;
                mx = e.X;
                my = e.Y;
            }
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) durum = false;
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("{0:d3} : {1:d3}", e.X, e.Y);
            if (durum) {
                (sender as PictureBox).Left += e.X - mx;
                (sender as PictureBox).Top += e.Y - my;
            }
        }
    }
}