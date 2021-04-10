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
            for (int i = 1; i <= 10; i++)
                listBox1.Items.Add(i.ToString("D2") + ".Kelime");
            label1.Text = listBox1.Items.Count.ToString();
            label2.Text = listBox2.Items.Count.ToString();
            listBox2.AllowDrop = true;
        }

        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int n = listBox1.SelectedIndex;
            if (n < 0) return;
            if (listBox1.DoDragDrop(listBox1.SelectedItem,
                DragDropEffects.All) == DragDropEffects.All)
            {
                listBox1.Items.RemoveAt(n);
                label1.Text = listBox1.Items.Count.ToString();
            }
        }

        private void ListBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ListBox2_DragDrop(object sender, DragEventArgs e)
        {
            string str = e.Data.GetData(DataFormats.Text).ToString();
            listBox2.Items.Insert(0, str);
            label2.Text = listBox2.Items.Count.ToString();
        }
    }
}