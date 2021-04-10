using System;
using System.Drawing;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Size = new Size(800,600);
            //WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            pBox.ImageLocation = @"..\..\..\Pictures\Resim.jpg";
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 3000;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
