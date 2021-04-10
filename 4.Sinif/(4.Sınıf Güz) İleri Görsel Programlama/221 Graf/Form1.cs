using System;
using System.Drawing;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(850, 500);
        }

        int sec = 60;
        string[] ss = new string[6];

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.BackColor = Color.Aqua;
            pBox.Dock = DockStyle.Fill;
            tmr.Interval = 1;
            tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (sec != dt.Second)
            {
                sec = dt.Second;
                ss[0] = dt.ToString();
                ss[1] = dt.ToShortDateString();
                ss[2] = dt.ToLongTimeString();
                ss[3] = dt.ToOADate().ToString();
                ss[4] = dt.Ticks.ToString();
                ss[5] = dt.ToFileTime().ToString();
                pBox.Invalidate();
            }
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boya = new SolidBrush(Color.Red);
            Font fnt = new Font("Consolas", 48, FontStyle.Bold);
            Graphics grf = e.Graphics;
            //grf.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < ss.Length; i++)
                grf.DrawString(ss[i], fnt, boya, 30, 10 + 80 * i);
            fnt.Dispose();
            boya.Dispose();
        }
    }
}