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
            Form2 frm = new Form2();
            frm.ShowDialog();
            frm.Dispose();
            // Text = frm.IsDisposed.ToString();
        }
    }
}