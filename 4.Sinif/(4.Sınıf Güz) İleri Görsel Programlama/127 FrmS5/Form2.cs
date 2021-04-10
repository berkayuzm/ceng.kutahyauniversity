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

        public string Ad { get; set; }
        public string Soyad { get; set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ad = textBox1.Text.Trim();
            Soyad = textBox2.Text.Trim();
            if (Ad.Length > 0 && Soyad.Length > 0)
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
