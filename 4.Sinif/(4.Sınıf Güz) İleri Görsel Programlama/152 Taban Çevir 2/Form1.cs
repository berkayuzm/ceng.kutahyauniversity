using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            if (checkBox1.Checked) n += 1;
            if (checkBox2.Checked) n += 2;
            if (checkBox3.Checked) n += 4;
            if (checkBox4.Checked) n += 8;
            if (checkBox5.Checked) n += 16;
            if (checkBox6.Checked) n += 32;
            if (checkBox7.Checked) n += 64;
            if (checkBox8.Checked) n += 128;
            label1.Text = n.ToString("D3");
            label2.Text = 'h' + n.ToString("X2");
        }
    }
}