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
            ClientSize = new Size(1200, 727);
        }

        readonly Random rnd = new Random();
        const int N = 56;
        PictureBox[] pBox;
        int[] A;
        int Sec, Say, Say1, Say2, Yer1, Yer2;
        string AdSyd = "İsimsiz Kişi";

        private string Göster(string AdSyd, int Say1, int Say2)
        {
            string str = "H A F I Z A     O Y U N U ( ";
            str += String.Format("{0} : {1} / {2} )", AdSyd, Say1, Say2);
            return str;
        }

        private void YeniOyun(int Secim)
        {
            int n, k = 0;
            Tmr.Enabled = false;
            Say = 0; Say1 = 0; Say2 = 0;
            Text = Göster(AdSyd, Say1, Say2);
            for (n = 0; n < N; n++)
            {
                pBox[n].Image = ImList.Images[0];
                pBox[n].Enabled = true;
            }
            Sec = Secim;
            if (Sec == 2) Tmr.Interval = 250; else Tmr.Interval = 750;
            if (Sec == 1) return;
            if (A == null) A = new int[N];
            else for (n = 0; n < N; n++) A[n] = 0;
            bool yok;
            int[] a = new int[N / 2];
            while (k < N / 2)
            {
                a[k] = 1 + rnd.Next(ImList.Images.Count - 1);
                yok = true;
                for (n = 0; n < k; n++)
                    if (a[n] == a[k]) { yok = false; break; }
                if (yok) k++;
            }
            for (n = 0; n < N; n++)
            {
                do k = rnd.Next(N); while (A[k] > 0);
                A[k] = a[n / 2];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pnl.ContextMenuStrip = cMenu;
            Pnl.Dock = DockStyle.Fill;
            int x, y, w = 150, h = 100;
            pBox = new PictureBox[N];
            for (int n = 0; n < N; n++)
            {
                x = w * (n % 8);
                y = h * (n / 8);
                pBox[n] = new PictureBox
                {
                    Name = String.Format("pBox{0:D2}", n),
                    Location = new Point(x, y),
                    Size = new Size(w, h)
                };
                pBox[n].MouseClick += new MouseEventHandler(PBoxMouseClick);
                Pnl.Controls.Add(pBox[n]);
            }
            YeniOyun(0);
        }

        private void PBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || Say > 1) return;
            PictureBox Nesne = sender as PictureBox;
            int n = int.Parse(Nesne.Name.Substring(4));
            Nesne.Image = ImList.Images[A[n]];
            Nesne.Enabled = false;
            if (++Say == 1) Yer1 = n;
            else
            {
                Yer2 = n;
                Text = Göster(AdSyd, Say1, ++Say2);
                Cursor = Cursors.Cross;
                Tmr.Enabled = true;
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Tmr.Enabled = false;
            Cursor = Cursors.Default;
            Say = 0;
            if(A[Yer1] == A[Yer2])
            {
                Text = Göster(AdSyd, ++Say1, Say2);
                pBox[Yer1].Image = null;
                pBox[Yer2].Image = null;
            }
            else
            {
                if (Sec < 2)
                {
                    pBox[Yer1].Image = ImList.Images[0];
                    pBox[Yer2].Image = ImList.Images[0];
                }
                pBox[Yer1].Enabled = true;
                pBox[Yer2].Enabled = true;
            }
            if (Say1 == 28)
                if (Sec == 0)
                {
                    Form3 frm = new Form3 { Say1 = Say1, Say2 = Say2, AdSyd = AdSyd };
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else MessageBox.Show("Kazandınız\nAma Boşa", "Mesaj");
        }

        private void YeniOyun_Click(object sender, EventArgs e)
        {
            YeniOyun(0);
        }

        private void AynıOyun_Click(object sender, EventArgs e)
        {
            YeniOyun(1);
        }

        private void AçıkOyun_Click(object sender, EventArgs e)
        {
            YeniOyun(2);
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bilgi_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void Rekorlar_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3 { Say1 = 0, Say2 = 0, AdSyd = null };
            frm.ShowDialog();
            frm.Dispose();
        }

        private void İsimGir_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4 { AdSyd = AdSyd };
            frm.ShowDialog();
            AdSyd = frm.AdSyd;
            frm.Dispose();
            Text = Göster(AdSyd, Say1, Say2);
        }
    }
}