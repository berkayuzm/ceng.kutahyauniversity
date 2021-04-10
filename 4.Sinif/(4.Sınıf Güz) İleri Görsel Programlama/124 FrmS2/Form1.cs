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

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 frm = new Form2();
            frm.str = label1.Text;
            frm.ShowDialog();
            label1.Text = frm.str;
            frm.Dispose();
            // Text = frm.IsDisposed.ToString();
            Show();
        }
    }
}