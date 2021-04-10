using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int say;
        public string str;

        private void Form2_Load(object sender, EventArgs e)
        {
            say++;
            label1.Text = say.ToString();
            textBox1.Text = str;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            str = textBox1.Text;
            label2.Text = textBox1.TextLength.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Hide();
        }
    }
}
