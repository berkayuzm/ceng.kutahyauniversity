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

        Random rnd = new Random();

        Color SeçRastgeleRenk()
        {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Color renk = SeçRastgeleRenk();
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i] is TextBox)
                    Controls[i].ForeColor = renk;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Color renk = SeçRastgeleRenk();
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i] is TextBox)
                    Controls[i].BackColor = renk;
            /*foreach (Control nesne in Controls)
                if (nesne is TextBox)
                    nesne.BackColor = renk;*/
            /*foreach (Control nesne in Controls)
                if (nesne.GetType().Name == "TextBox")
                    nesne.BackColor = renk;*/
        }
    }
}