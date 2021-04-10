using System;
using System.Drawing;
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
            Text = "Nesne Sayısı : " + Controls.Count.ToString();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.TextLength.ToString();
            label2.Text = textBox2.TextLength.ToString();
            string s1 = textBox1.Text.ToUpper();
            string s2 = textBox2.Text.ToUpper();
            Color renk = (s1 == s2) ? Color.Green : Color.Red;
            //foreach (Control nesne in Controls)
                //nesne.ForeColor = renk;
            for (int i = 0; i < Controls.Count; i++)
                Controls[i].ForeColor = renk;
        }
    }
}