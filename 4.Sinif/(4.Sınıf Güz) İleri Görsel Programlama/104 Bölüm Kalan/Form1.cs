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
            textBox4.ResetText();
        }

        private void TextBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int a))
            {
                MessageBox.Show("Tamsayı Gir", "Bilgi");
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }
            bool drm = int.TryParse(textBox2.Text, out int b);
            if (b == 0)
            {
                string str = drm ? "Bölen Sıfır Olmamalı" : "Tamsayı Gir";
                MessageBox.Show(str, "Bilgi");
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }
            textBox3.Text = (a / b).ToString();
            textBox4.Text = (a % b).ToString();
        }
    }
}