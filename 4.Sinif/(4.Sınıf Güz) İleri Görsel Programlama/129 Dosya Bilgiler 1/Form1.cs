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

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string path = @"c:\windows";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo fi in di.GetFiles())
                listBox1.Items.Add(fi.Name);
        }
    }
}