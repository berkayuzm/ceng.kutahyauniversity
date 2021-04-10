using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int say;

        private void Form2_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            CancelButton = button2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "htemurtas")
                DialogResult = DialogResult.OK;
            else
            {
                textBox1.ResetText();
                textBox1.Focus();
                Text = "Yanlış Şifre, Deneme : " + (++say).ToString();
                if (say == 3)
                {
                    Close(); //DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Programı Yetkisiz Kişiler Kullanamaz",
                        "Bilgi");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
