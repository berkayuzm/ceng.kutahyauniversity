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

        int i, j;

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Nesne Sayısı = " + Controls.Count.ToString();
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter = " + (i = 0).ToString();
            label2.Text = "Leave = " + (j = 0).ToString();
            for (int k = 0; k < Controls.Count; k++)
                if (Controls[k] is TextBox)
                {
                    Controls[k].Text = "Hasan TEMURTAŞ";
                    Controls[k].BackColor = Color.Yellow;
                    Controls[k].ForeColor = Color.Green;
                }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            label1.Text = "Enter = " + (++i).ToString();
            (sender as Control).BackColor = Color.Cyan;
            (sender as Control).ForeColor = Color.Red;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            label2.Text = "Leave = " + (++j).ToString();
            (sender as Control).BackColor = Color.Yellow;
            (sender as Control).ForeColor = Color.Green;
        }
    }
}