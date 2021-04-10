using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Button2_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Dock = DockStyle.None;
            ClientSize = panel2.Size;
            panel2.Dock = DockStyle.Fill;
            panel2.BringToFront();
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            panel1.Dock = DockStyle.None;
            ClientSize = panel1.Size;
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
        }
    }
}