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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) return;
            string str = String.Format("Say {0} : {1}", ++n, x);
            listBox1.Items.Insert(0, str);
        }
    }
}