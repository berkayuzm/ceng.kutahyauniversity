using System;
using System.IO;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                BulKlasorDosya(fbd.SelectedPath);
            }
            fbd.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        void BulKlasorDosya(string Klasor)
        {
            listBox1.Items.Add(Klasor);
            string[] files = Directory.GetFiles(Klasor);
            foreach (string file in files)
                listBox1.Items.Add(file);
            string[] dirs = Directory.GetDirectories(Klasor);
            foreach (string dir in dirs)
                BulKlasorDosya(dir);
        }
    }
}