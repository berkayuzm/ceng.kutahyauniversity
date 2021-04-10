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
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.TextLength.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.TextLength.ToString();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b') return;
            Console.Beep(1500, 50);
            e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b') return;
            Console.Beep(750, 50);
            e.Handled = true;
        }
    }
}