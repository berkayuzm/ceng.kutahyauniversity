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
            AcceptButton = button1;
            CancelButton = button2;
            textBox1.ResetText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ResetText();
            label2.Text = textBox1.TextLength.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.Focus();
        }
    }
}