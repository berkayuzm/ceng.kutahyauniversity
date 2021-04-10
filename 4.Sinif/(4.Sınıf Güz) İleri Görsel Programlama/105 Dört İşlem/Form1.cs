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

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            textBox3.ResetText();
            label1.Text = "?";
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string str = "Reel Sayı Gir";
            if (!double.TryParse(textBox1.Text, out double a))
            {
                MessageBox.Show(str, "Bilgi");
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }
            if (!double.TryParse(textBox2.Text, out double b))
            {
                MessageBox.Show(str, "Bilgi");
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            double c;
            switch ((sender as Control).Name)
            {
                case "button1": c = a + b; str = "+"; break;
                case "button2": c = a - b; str = "-"; break;
                case "button3": c = a * b; str = "*"; break;
                default: c = a / b; str = "/"; break;
            }
            label1.Text = str;
            textBox3.Text = c.ToString();
        }
    }
}