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

        int n;

        private void Göster()
        {
            n = listBox1.SelectedIndex;
            label1.Text = listBox1.Items.Count.ToString();
            label2.Text = n.ToString();
            if (n >= 0) label3.Text = listBox1.Items[n].ToString();
            else label3.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ss = {"Tahsin", "Şule", "Mehmet", "Ali",
                "Ensar", "Hasan", "Recep", "Mücahit", "Serdar" };
            listBox1.Items.AddRange(ss);
            textBox1.ResetText();
            Göster();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.TextLength > 0) {
                n = 1 + listBox1.SelectedIndex;
                listBox1.Items.Insert(n, textBox1.Text);
                //listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Clear();
            textBox1.Focus();
            Göster();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            n = listBox1.SelectedIndex;
            if (n >= 0) listBox1.Items.RemoveAt(n);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Göster();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Göster();
        }
    }
}