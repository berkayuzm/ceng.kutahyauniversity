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
            UpDown1.Maximum = (decimal)1e3;
            UpDown2.Maximum = (decimal)1e9;
            UpDown1.Value = 2;
            UpDown2.Value = 1000;
            Yenile();
        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            int n = (int)UpDown1.Value;
            int x = (int)UpDown2.Value;
            label1.Text = TabanÇevir(x, n);
        }

        string TabanÇevir(int x, int n)
        {
            if (n < 2 || n > 16) return "Taban Aralık Dışı";
            if (x < 0 || x > 1e6) return "Sayı Aralık Dışı";
            int gec;
            string str = null;
            while (true) {
                gec = x % n;
                if (gec < 10) str = (char)(48 + gec) + str;
                else str = (char)(55 + gec) + str;
                x /= n;
                if (x == 0) break;
            }
            return str;
        }
    }
}