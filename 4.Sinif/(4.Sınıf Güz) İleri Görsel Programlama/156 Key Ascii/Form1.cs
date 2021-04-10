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
            string[] sDizi = { "All Characters", "Control", "Digit",
                "Letter", "Lower", "Number", "Symbol", "Upper" };
            // comboBox.Items.Clear();
            cBox.Items.AddRange(sDizi);
            listBox.MultiColumn = true;
            listBox.ColumnWidth = 135;
        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            char c;
            string s;
            listBox.Items.Clear();
            for (int n = (int)char.MinValue; n <= (int)char.MaxValue; n++)
            {
                c = (char)n;
                s = string.Format("{0,10}{1,4}", n, c);
                switch (cBox.SelectedIndex)
                {
                    case 0:
                        listBox.Items.Add(s);
                        break;
                    case 1:
                        if (char.IsControl(c)) listBox.Items.Add(s);
                        break;
                    case 2:
                        if (char.IsDigit(c)) listBox.Items.Add(s);
                        break;
                    case 3:
                        if (char.IsLetter(c)) listBox.Items.Add(s);
                        break;
                    case 4:
                        if (char.IsLower(c)) listBox.Items.Add(s);
                        break;
                    case 5:
                        if (char.IsNumber(c)) listBox.Items.Add(s);
                        break;
                    case 6:
                        if (char.IsSymbol(c)) listBox.Items.Add(s);
                        break;
                    case 7:
                        if (char.IsUpper(c)) listBox.Items.Add(s);
                        break;
                }
            }
        }

        private void cBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}