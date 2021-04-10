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

        Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i, k = rnd.Next(2, 26);
            int n = 1000 * k;
            int[] a = new int[k];
            for (i = 0; i < n; i++) a[rnd.Next(k)]++;
            string str = string.Format("{0,21} = {1}", "Çekiliş Sayısı", n);
            str += string.Format("\n{0,14}{1,14}", "Gelen", "Frekans");
            str += string.Format("\n{0,16}{0,13}", "---------");
            for (i = 0; i < k; i++)
                str += string.Format("\n{0,12}{1,15}", i + 1, a[i]);
            richTextBox1.Text = str;
        }
    }
}