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
            label1.ResetText();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "Alt : " + e.Alt
                + "\nControl : " + e.Control
                + "\nShift : " + e.Shift
                + "\nKeyCode : " + e.KeyCode
                + "\nKeyData : " + e.KeyData
                + "\nKeyValue : " + e.KeyValue
                + "\nHandled : " + e.Handled
                + "\nModifiers : " + e.Modifiers
                + "\nSuppressKeyPress : " + e.SuppressKeyPress;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.ResetText();
        }
    }
}