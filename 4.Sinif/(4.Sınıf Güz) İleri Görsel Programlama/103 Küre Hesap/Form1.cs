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
            textBox1.ResetText();
            label3.Text = Math.PI.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ResetText();
            label2.ResetText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (!double.TryParse(textBox1.Text, out double r))
            {
                MessageBox.Show("Reel Sayı Gir", "Bilgi");
                textBox1.SelectAll();
                return;
            }
            double yalan = 4 * Math.PI * r * r;
            double hacim = yalan * r / 3;
            label1.Text = yalan.ToString();
            label2.Text = hacim.ToString();
        }
    }
}