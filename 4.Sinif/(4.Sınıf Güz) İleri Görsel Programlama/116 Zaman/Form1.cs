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
            Button1_Click(sender, e);
            Button2_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int dgr = Environment.TickCount;
            label1.Text = dgr.ToString() + " salise";
            string str = (dgr % 1000).ToString() + " salise";
            dgr /= 1000;
            str = (dgr % 60).ToString() + " saniye, " + str;
            dgr /= 60;
            str = (dgr % 60).ToString() + " dakika, " + str;
            dgr /= 60;
            str = (dgr % 24).ToString() + " saat, " + str;
            str = (dgr / 24).ToString() + " gun, " + str;
            label2.Text = str;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString();
            label4.Text = dt.ToShortDateString();
            label5.Text = dt.ToLongTimeString();
            label6.Text = dt.ToOADate().ToString();
            label7.Text = dt.Ticks.ToString();
        }
    }
}