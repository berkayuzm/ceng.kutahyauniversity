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
            vScrollBar1.Maximum = 264;
            vScrollBar2.Maximum = 264;
            vScrollBar3.Maximum = 264;
        }

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = rnd.Next(256);
            vScrollBar2.Value = rnd.Next(256);
            vScrollBar3.Value = rnd.Next(256);
        }

        private void VScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int r = 255 - vScrollBar1.Value;
            int g = 255 - vScrollBar2.Value;
            int b = 255 - vScrollBar3.Value;
            panel1.BackColor = Color.FromArgb(r, g, b);
            label1.Text = r.ToString("D3");
            label2.Text = g.ToString("D3");
            label3.Text = b.ToString("D3");
            label4.Text = r.ToString("X2");
            label5.Text = g.ToString("X2");
            label6.Text = b.ToString("X2");
        }
    }
}