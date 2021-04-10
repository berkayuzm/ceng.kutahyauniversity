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
            textBox3.ResetText();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a)) {
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }
            if (!double.TryParse(textBox2.Text, out double b)) {
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            if (!double.TryParse(textBox3.Text, out double c)) {
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
            double x1, x2, delta = b * b - 4 * a * c;
            if (delta < 0) label3.Text = "Kökler Sanal";
            else
            {
                label3.Text = delta > 0 ? "Kökler Reel" : "Kökler Katlı";
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                label1.Text = x1.ToString("f6");
                label2.Text = x2.ToString("f6");
            }
        }
    }
}