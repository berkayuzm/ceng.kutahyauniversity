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
            string[] ss = { "Elma", "Armut", "Portakal", "Limon",
                "Karpuz", "Kavun", "Erik", "İncir", "Şeftali", "Kayısı" };
            listBox1.Items.AddRange(ss);
            CountItems();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "button1":
                    listBox2.Items.AddRange(listBox1.Items);
                    listBox1.Items.Clear();
                    break;
                case "button2":
                    if (listBox1.SelectedIndex < 0) return;
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    break;
                case "button3":
                    if (listBox2.SelectedIndex < 0) return;
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    break;
                default:
                    listBox1.Items.AddRange(listBox2.Items);
                    listBox2.Items.Clear();
                    break;
            }
            CountItems();
        }
    }
}