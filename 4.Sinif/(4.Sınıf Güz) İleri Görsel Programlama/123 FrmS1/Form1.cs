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

        Form2 frm;

        private void Form1_Load(object sender, EventArgs e)
        {
            frm = new Form2();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frm.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            frm.str = label1.Text;
            frm.ShowDialog();
            label1.Text = frm.str;
            Show();
        }
    }
}