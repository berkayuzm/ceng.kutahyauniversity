using System;
using System.Drawing;
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
            FontFamily[] ff = FontFamily.Families;
            for (int i = 0; i < ff.Length; i++)
                comboBox1.Items.Add(ff[i].Name);
            int[] a = { 8, 9, 10, 11, 12, 14, 16, 18, 20,
                22, 24, 26, 28, 36, 48, 72 };
            for (int i = 0; i < a.Length; i++)
                comboBox2.Items.Add(a[i]);
            textBox1.Text = "Hasan TEMURTAŞ\r\nBilgisayar Mühendisliği";
            comboBox2.SelectedIndex = 5;
            comboBox1.SelectedIndex = 52;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox1.Text,
                float.Parse(comboBox2.Text), textBox1.Font.Style);
        }
    }
}