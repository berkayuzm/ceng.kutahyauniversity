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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form2();
                frm.Show();
            }
            else {
                frm.Activate();
                frm.WindowState = FormWindowState.Normal;
            }
        }
    }
}