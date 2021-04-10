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
            ClientSize = new Size(800, 600);
        }

        int nTab = 7;
        TabControl tc;
        Random rnd;

        private Color SeçRasgeleRenk() {
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tc.SelectTab((1 + tc.SelectedIndex) % nTab);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            tc = new TabControl();
            tc.Dock = DockStyle.Fill;

            //tc.Appearance = TabAppearance.FlatButtons;
            //tc.ItemSize = new Size(0,1);
            tc.SizeMode = TabSizeMode.Fixed;

            for (int n = 1; n <= nTab; n++) {
                TabPage tp = new TabPage();
                tp.Text = "Sayfa" + n;
                tp.BackColor = SeçRasgeleRenk();
                Button btn = new Button();
                btn.Text = (1 + n % nTab).ToString() + ".Sayfaya Git";
                btn.Size = new Size(250, 50);
                btn.Location = new Point(rnd.Next(500), rnd.Next(450));
                //btn.BackColor = SystemColors.Control;
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(Btn_Click);
                tp.Controls.Add(btn);
                tc.Controls.Add(tp);
            }
            Controls.Add(tc);
        }
    }
}