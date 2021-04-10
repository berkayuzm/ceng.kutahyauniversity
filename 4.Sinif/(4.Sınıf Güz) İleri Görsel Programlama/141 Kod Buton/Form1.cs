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

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Text = "Üzerinde '" + btn.Text + "' yazan '" + btn.Name
                + "' isimli butona basıldı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            AutoScroll = true;
            Font fnt = new Font("Consolas", 18F, FontStyle.Bold);
            int n = 50, x, y, w = 130, h = 45;
            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(w, h);
                x = 25 + (w + 25) * (i % 5);
                y = 25 + (h + 12) * (i / 5);
                btn.Location = new Point(x, y);
                //btn.BackColor = SystemColors.Control;
                btn.UseVisualStyleBackColor = true;
                btn.ForeColor = Color.Red;
                btn.Name = String.Format("Buton{0:D2}", i + 1);
                btn.Text = String.Format("Hasan{0:D2}", i + 1);
                btn.Font = fnt;
                btn.Click += new EventHandler(Btn_Click);
                Controls.Add(btn);
            }
            fnt.Dispose();
        }
    }
}