using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static int x;

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Left = rnd.Next(750);
            Top = rnd.Next(50);
            label1.Text = (++x).ToString();
        }
    }
}
