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
            listBox1.AllowDrop = true;
            listBox1.Dock = DockStyle.Fill;
        }

        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ListBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] ss = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int n = 0; n < ss.Length; n++) listBox1.Items.Add(ss[n]);
        }
    }
}