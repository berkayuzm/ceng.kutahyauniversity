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

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }
}
