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

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
            richTextBox1.ReadOnly = true;
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int m, M = rnd.Next(10, 51);
            int n, N = rnd.Next(4, 16);
            double[,] a = new double[M, N];
            string str = string.Format("{0,50}\n","A Matrisi");
            str += string.Format("Satır Sayısı = {0,2}\n", M);
            str += string.Format("Sütun Sayısı = {0,2}\n", N);
            for (m = 0; m < M; m++)
            {
                for (n = 0; n < N; n++)
                {
                    a[m, n] = Math.Round(100 - 200 * rnd.NextDouble(), 6);
                    str += string.Format("{0,14}", a[m, n]);
                }
                str += "\n";
            }
            richTextBox1.Text = str;
        }
    }
}