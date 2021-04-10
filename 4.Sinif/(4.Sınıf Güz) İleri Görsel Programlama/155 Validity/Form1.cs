using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m, n;

        private void DurumSay()
        {
            Text = "Validating ---> " + m.ToString() + " / " + n.ToString();
            // Text = string.Format("Validating ---> {0} / {1}", m, n);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            DurumSay();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int gec))
                label1.Text = gec.ToString();
            else label1.ResetText();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double gec))
                label2.Text = gec.ToString();
            else label2.ResetText();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _)) {
                m++;
                e.Cancel = true;
            }
            DurumSay();
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out _)) {
                n++;
                e.Cancel = true;
            }
            DurumSay();
        }
    }
}