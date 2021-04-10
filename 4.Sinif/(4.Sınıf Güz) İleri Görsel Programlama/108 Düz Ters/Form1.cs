using System;
using System.Linq;
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
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            int n = textBox1.TextLength;
            label1.Text = n.ToString();
            string s = null;
            for (int i = 0; i < n; i++)
                s += textBox1.Text[n - 1 - i];
            textBox3.Text = s;
        }

        private void TextBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            Console.Beep(2500, 50);
        }
    }
}