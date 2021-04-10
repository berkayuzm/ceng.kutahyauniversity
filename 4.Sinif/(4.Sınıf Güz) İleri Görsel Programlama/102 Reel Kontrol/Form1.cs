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

        ErrorProvider ErPr;

        private void Form1_Load(object sender, EventArgs e)
        {
            ErPr = new ErrorProvider();
            textBox1.ResetText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Color renk;
            ErPr.Clear();
            if (double.TryParse(textBox1.Text, out double x))
            {
                renk = Color.Green;
                label2.Text = "Sayı : " + x.ToString();
            }
            else
            {
                renk = Color.Red;
                label2.Text = "Reel Sayı Değil";
                ErPr.SetError(textBox1, "Reel Sayı Değil");
            }
            label1.Text = "Uzunluk : " + textBox1.TextLength.ToString();
            for (int i = 0; i < Controls.Count; i++)
                Controls[i].ForeColor = renk;
        }
    }
}