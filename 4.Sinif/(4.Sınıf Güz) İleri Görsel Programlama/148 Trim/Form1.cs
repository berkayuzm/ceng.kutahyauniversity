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
            textBox1.MaxLength = 24;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            label1.Text = s.Length.ToString();
            label2.Text = '{' + s + '}';
            label3.Text = '{' + s.Trim() + '}';
            label4.Text = '{' + s.TrimStart() + '}';
            label5.Text = '{' + s.TrimEnd() + '}';
        }
    }
}