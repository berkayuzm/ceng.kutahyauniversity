using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form3 : Form
    {
		public Form3()
        {
            InitializeComponent();
            ClientSize = new Size(400, 585);
        }

		public string AdSyd;
		public int Say1, Say2;

		private void Form3_Load(object sender, EventArgs e)
        {
			int N = 25;
			string str, fName = @"Rekorlar.txt";
			string[] aName = new string[N];
			int[] aScore = new int[N];
			DataGridView dgv = new DataGridView()
			{
				Font = new Font("Consolas", 12f, FontStyle.Bold),
				Dock = DockStyle.Fill,
				ColumnHeadersHeight = 30,
				RowCount = N,
				ColumnCount = 3,
				RowHeadersVisible = false,
				Enabled = false,
			};
			dgv.Columns[0].Width = 60;
			dgv.Columns[0].HeaderText = "Sıra";
			dgv.Columns[1].Width = 255;
			dgv.Columns[1].HeaderText = "Ad Soyad";
			dgv.Columns[2].Width = 80;
			dgv.Columns[2].HeaderText = "Puan";
			dgv.ClearSelection();
			Controls.Add(dgv);
			int n, m, M = 0;
			if (File.Exists(fName))
			{
				StreamReader sr = File.OpenText(fName);
				for (n = 0; n < N; n++)
				{
					str = sr.ReadLine();
					if (str == null) break; else M++;
					string[] ss = str.Split();
					if (int.TryParse(ss[ss.Length - 1], out int gec))
						aScore[n] = gec;
					else { M--; break; }
					aName[n] = null;
					for (m = 0; m < ss.Length - 1; m++)
						if (ss[m] != string.Empty)
							aName[n] += ss[m] + ' ';
				}
				sr.Close();
			}
			int k = -1;
			if (Say1 == 28)
			{
				if (M == N) M--;
				aName[M] = AdSyd;
				aScore[M++] = Say2;
				for (n = M - 1; n > 0; n--)
					if (aScore[n] <= aScore[n - 1])
					{
						k = n - 1;
						m = aScore[n];
						aScore[n] = aScore[k];
						aScore[k] = m;
						str = aName[n];
						aName[n] = aName[k];
						aName[k] = str;
					}
					else { k = n; break; }
			}
			if (M == 0) return;
			StreamWriter sw = File.CreateText(fName);
			for (n = 0; n < M; n++)
			{
				sw.Write("{0,-24}{1,6}", aName[n], aScore[n]);
				sw.WriteLine();
			}
			sw.Close();
			for (n = 0; n < M; n++)
			{
				dgv[0, n].Value = (n + 1).ToString();
				dgv[1, n].Value = aName[n];
				dgv[2, n].Value = aScore[n].ToString();
			}
			if (k >= 0) dgv.Rows[k].Selected = true;
		}
    }
}