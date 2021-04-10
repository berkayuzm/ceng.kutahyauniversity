using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread thr;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thr = new Thread(new ThreadStart(Yordam));
            thr.Start();
        }

        private void Yordam()
        {
            const int N = 100;
            int n = 0;
            long t1, t2 = DateTime.Now.Ticks;
            double fark;
            string str;
            while (true)
            {
                Thread.Sleep(10);
                t1 = DateTime.Now.Ticks;
                if (t1 > t2)
                {
                    t1 = DateTime.Now.Ticks;
                    fark = (t1 - t2) * 1e-4;
                    t2 = t1;
                    str = string.Format("{0,6}.TickCount : {1,12:F4} ms", ++n, fark);
                    listBox1.Items.Insert(0, str);
                    if (n == N)
                    {
                        listBox1.ForeColor = Color.Blue;
                        listBox1.BackColor = Color.Yellow;
                        thr.Abort();
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thr.IsAlive)
            {
                MessageBox.Show("Thread Yordamı Çalışıyor", "Uyarı");
                e.Cancel = true;
            }
        }
    }
}