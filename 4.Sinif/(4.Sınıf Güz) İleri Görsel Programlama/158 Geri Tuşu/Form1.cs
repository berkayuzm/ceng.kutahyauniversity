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

        private void Button1_Click(object sender, EventArgs e)
        {
            int n = textBox1.Text.Length;
            if (n > 0)
                textBox1.Text = textBox1.Text.Substring(0, n - 1);
            textBox1.Focus();
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}