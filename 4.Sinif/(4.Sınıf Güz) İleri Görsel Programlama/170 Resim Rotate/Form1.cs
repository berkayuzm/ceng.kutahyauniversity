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

        OpenFileDialog ofd = new OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (RotateFlipType x in Enum.GetValues(typeof(RotateFlipType)))
                comboBox1.Items.Add(x);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                RotateFlipType rt = (RotateFlipType)comboBox1.SelectedItem;
                Image image = pictureBox1.Image;
                image.RotateFlip(rt);
                pictureBox1.Refresh();
            }
        }
    }
}