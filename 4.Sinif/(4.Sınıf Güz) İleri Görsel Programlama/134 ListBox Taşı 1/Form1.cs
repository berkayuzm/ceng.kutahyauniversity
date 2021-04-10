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

        private void CountItems()
        {
            label1.Text = listBox1.Items.Count.ToString();
            label2.Text = listBox2.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
                listBox1.Items.Add(i.ToString("D2") + ".Kelime");
            CountItems();
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (sender == listBox1) {
                if (listBox1.SelectedIndex < 0) return;
                listBox2.Items.Insert(0, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            } else {
                if (listBox2.SelectedIndex < 0) return;
                listBox1.Items.Insert(0, listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            CountItems();
        }
    }
}