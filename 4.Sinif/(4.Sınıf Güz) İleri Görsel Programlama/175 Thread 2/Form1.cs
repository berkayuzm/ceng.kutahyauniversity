using System;
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

        const int N = 25;

        void Yordam1()
        {
            for (int n = 1; n <= N; n++) {
                Thread.Sleep(250);
                listBox1.Items.Insert(0, "Yordam1 : " + n);
            }
            thr1.Abort();
        }

        void Yordam2()
        {
            for (int n = 1; n <= N; n++) {
                Thread.Sleep(500);
                listBox2.Items.Insert(0, "Yordam2 : " + n);
            }
            thr2.Abort();
        }

        void Yordam3()
        {
            for (int n = 1; n <= N; n++) {
                Thread.Sleep(750);
                listBox3.Items.Insert(0,"Yordam3 : " + n);
            }
            thr3.Abort();
        }

        Thread thr1, thr2, thr3;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thr1 = new Thread(new ThreadStart(Yordam1));
            thr1.Start();
            thr2 = new Thread(new ThreadStart(Yordam2));
            thr2.Start();
            thr3 = new Thread(new ThreadStart(Yordam3));
            thr3.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thr1.IsAlive || thr2.IsAlive || thr3.IsAlive)
            {
                MessageBox.Show("Thread Yordamları Çalışıyor", "Uyarı");
                e.Cancel = true;
            }
        }
    }
}