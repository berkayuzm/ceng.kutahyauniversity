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
        long n;

        void Yordam()
        {
            int r, g, b;
            int x, y, a = 100;
            Random rnd = new Random();
            Graphics grf = CreateGraphics();
            SolidBrush boya = new SolidBrush(Color.Black);
            while (true)
            {
                n++;
                Text = n.ToString();
                //Thread.Sleep(50);
                r = rnd.Next(256);
                g = rnd.Next(256);
                b = rnd.Next(256);
                boya.Color = Color.FromArgb(r, g, b);
                x = rnd.Next(ClientSize.Width - a);
                y = rnd.Next(ClientSize.Height - a);
                grf.FillEllipse(boya, x, y, a, a);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thr.Abort();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (thr == null)
            {
                thr = new Thread(new ThreadStart(Yordam));
                thr.Start();
            }
            else
            {
                if (thr.IsAlive)
                    thr.Abort();
                else
                {
                    thr = new Thread(new ThreadStart(Yordam));
                    thr.Start();
                }
            }
        }
    }
}