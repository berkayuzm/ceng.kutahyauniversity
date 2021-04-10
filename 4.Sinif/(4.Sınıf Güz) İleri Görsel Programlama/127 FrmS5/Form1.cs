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
            label1.ResetText();
            label2.ResetText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                label1.Text = frm.Ad;
                label2.Text = frm.Soyad;
            } else {
                label1.ResetText();
                label2.ResetText();
                MessageBox.Show("Ad Soyad Girilmemiş\n Veya İptal Edilmiş");
            }
            frm.Dispose();
        }
    }
}