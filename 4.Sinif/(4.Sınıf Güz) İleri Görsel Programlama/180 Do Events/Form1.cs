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

        int n;
        long t1, t2;
        double dt;
        bool drm;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = n.ToString();
            label2.Text = dt.ToString("F6") + " ms";
            button1.Text = "Saydır";
            button1.ForeColor = Color.Red;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            drm = !drm;
            if (drm)
            {
                t1 = DateTime.Now.Ticks;
                button1.Text = "Sayıyor";
                button1.ForeColor = Color.Green;
            }
            else
            {
                button1.Text = "Saydır";
                button1.ForeColor = Color.Red;
            }
            while (drm)
            {
                t2 = DateTime.Now.Ticks;
                if (t2 > t1)
                {
                    dt = (t2 - t1) / 1e4;
                    t1 = t2;
                    label1.Text = (++n).ToString();
                    label2.Text = dt.ToString("F6") + " ms";
                    Application.DoEvents();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = drm;
            if (e.Cancel) MessageBox.Show("Önce Saymayı Durdur", "Bilgi");
        }
    }
}
