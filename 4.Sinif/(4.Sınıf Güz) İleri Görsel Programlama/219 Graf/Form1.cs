using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        string DirName;
        const int N = 16;
        int n = N - 1;

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(800, 600);
        }

        private void ResimGöster()
        {
            n = (n + 1) % N;
            Text = string.Format(DirName + "Rsm{0:D2}.jpg", n);
            pBox.ImageLocation = Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
            pBox.SizeMode = PictureBoxSizeMode.CenterImage;
            DirName = new DirectoryInfo("../../../Pictures/").FullName;
            ResimGöster();
            tmr.Interval = 250;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            ResimGöster();
        }
    }
}