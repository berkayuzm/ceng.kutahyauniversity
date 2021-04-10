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

        string s;

        private void Form1_Load(object sender, EventArgs e)
        {
            s = "Hasan TEMURTAŞ      ";
            label1.Text = s;
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Blue;
            timer1.Interval = 250;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s = s.Substring(1) + s[0];
            label1.Text = s;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}