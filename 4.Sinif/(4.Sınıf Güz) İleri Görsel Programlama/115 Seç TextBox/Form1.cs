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
            for (int n = 1; n < 6; n++)
                comboBox1.Items.Add("Metin Kutusu " + n.ToString());
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "textBox1": comboBox1.SelectedIndex = 0; break;
                case "textBox2": comboBox1.SelectedIndex = 1; break;
                case "textBox3": comboBox1.SelectedIndex = 2; break;
                case "textBox4": comboBox1.SelectedIndex = 3; break;
                default: comboBox1.SelectedIndex = 4; break;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: textBox1.Focus(); textBox1.SelectAll(); break;
                case 1: textBox2.Focus(); textBox2.SelectAll(); break;
                case 2: textBox3.Focus(); textBox3.SelectAll(); break;
                case 3: textBox4.Focus(); textBox4.SelectAll(); break;
                case 4: textBox5.Focus(); textBox5.SelectAll(); break;
            }
        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            Console.Beep(1500, 25);
        }
    }
}