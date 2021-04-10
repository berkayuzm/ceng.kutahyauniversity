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

        int say, ekle;

        private void Form1_Load(object sender, EventArgs e)
        {
            pBar.Maximum = 1000;
            tmr.Interval = 1;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender == button1) ekle = -1;
            else if (sender == button2) ekle = 0;
            else ekle = 1;
            tmr.Enabled = ( ekle != 0 );
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            say += ekle;
            if (say < 0) say = 0;
            if (say > pBar.Maximum) say = pBar.Maximum;
            pBar.Value = say;
            label1.Text = string.Format("Yüzde:{0,3}%", say/10);
        }
    }
}