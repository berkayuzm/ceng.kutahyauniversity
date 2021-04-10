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

        const int N = 100;
        int n;
        long t1, t2;
        double fark;
        string str;

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr.Interval = 1;
            tmr.Enabled = true;
            t2 = DateTime.Now.Ticks;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t1 = DateTime.Now.Ticks;
            fark = (t1 - t2) * 1e-4;
            t2 = t1;
            str = string.Format("{0,6}.TickCount : {1,12:F4} ms", ++n, fark);
            listBox1.Items.Insert(0, str);
            if (n == 100)
            {
                listBox1.ForeColor = Color.Blue;
                listBox1.BackColor = Color.Yellow;
                tmr.Enabled = false;
            }
        }
    }
}