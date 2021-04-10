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

        bool Esc;

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.Focus();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox1.TextLength.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Esc;
            if (e.Cancel)
                MessageBox.Show("Sadece Esc tuşuna\nbasılarak çıkılabilir", "Uyarı");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) {
                Esc = true;
                Close();
            }
        }
    }
}