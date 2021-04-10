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

        int n;
        long t1, t2;
        double dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = n.ToString();
            label2.Text = dt.ToString("F4") + " ms";
            button1.Text = "Saydır";
            button1.ForeColor = Color.Red;
            timer1.Interval = 1000;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                t1 = DateTime.Now.Ticks;
                button1.Text = "Sayıyor";
                button1.ForeColor = Color.Green;
            }
            else
            {
                button1.Text = "Saydır";
                button1.ForeColor = Color.Red;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t2 = t1;
            t1 = DateTime.Now.Ticks;
            dt = (t1 - t2) / 10000.0;
            label1.Text = (++n).ToString();
            label2.Text = dt.ToString("F4") + " ms";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = timer1.Enabled;
            if (e.Cancel) MessageBox.Show("Önce Saymayı Durdur", "Bilgi");
        }
    }
}