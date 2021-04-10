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

        private Image imgA, imgB;
        private Rectangle rectA, rectB;

        private int Sec;

        private void Form1_Load(object sender, EventArgs e)
        {
            imgA = new Bitmap("../../../Pictures/Rsm00.jpg");
            imgB = new Bitmap("../../../Pictures/Rsm01.jpg");
            rectA = new Rectangle(25, 25, 400, 300);
            rectB = new Rectangle(450, 25, 400, 300);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);

            if (rectA.Contains(p))
            {
                Sec = 1;
                Text = "1. Resim Tıklandı";
            }
            else if (rectB.Contains(p))
            {
                Sec = 2;
                Text = "2. Resim Tıklandı";
            }
            else
            {
                Sec = 0;
                Text = "Resimler";
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            grf.DrawImage(imgA, rectA);
            grf.DrawImage(imgB, rectB);
            Pen klm = new Pen(Color.Red, 5);
            switch (Sec)
            {
                case 1: grf.DrawRectangle(klm, rectA); break;
                case 2: grf.DrawRectangle(klm, rectB); break;
            }
        }
    }
}