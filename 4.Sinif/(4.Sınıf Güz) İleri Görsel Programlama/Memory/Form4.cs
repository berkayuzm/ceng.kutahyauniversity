using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string AdSyd;

        private void Form4_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            CancelButton = button2;
            textBox1.Text = AdSyd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdSyd = null;
            string[] ss = textBox1.Text.Split();
            for (int n = 0; n < ss.Length; n++)
                if (ss[n] != String.Empty)
                    AdSyd += ' ' + ss[n];
            AdSyd = AdSyd.Substring(1);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}