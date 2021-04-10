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

        string s;
        const int n = 100;
        double[] a = new double[n];
        double[] b = new double[n];
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Dizi Boyutu = " + n.ToString();
            string[] ss = { "Küçükten Büyüğe", "Büyükten Küçüğe" };
            comboBox1.Items.AddRange(ss);
            Button1_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                a[i] = 1000 * rnd.NextDouble();
                s = string.Format("{0,16:f9}", a[i]);
                listBox1.Items.Add(s);
            }
            ComboBox1_SelectedIndexChanged(sender, e);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (comboBox1.SelectedIndex < 0) return;
            Array.Copy(a, b, n);
            Array.Sort(b);
            if (comboBox1.SelectedIndex > 0) Array.Reverse(b);
            for (int i = 0; i < n; i++)
            {
                s = string.Format("{0,16:f9}", b[i]);
                listBox2.Items.Add(s);
            }
        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}