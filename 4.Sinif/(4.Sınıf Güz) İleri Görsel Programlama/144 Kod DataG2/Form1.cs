using System;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DataGridView dgv = new DataGridView();
            dgv.Font = new Font("Consolas", 14f, FontStyle.Bold);
            dgv.Dock = DockStyle.Fill;
            //dgv.RowHeadersWidth = 50;
            //dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeight = 40;
            dgv.AllowUserToAddRows = false;
            dgv.RowTemplate.Height = 30;
            int m, n, M = 15, N = 5;
            DataTable Table = new DataTable();
            for (n = 0; n < N; n++) {
                Table.Columns.Add((n + 1).ToString() + ".Sütun");
            }
            string[] s = new string[N];
            for (m = 1; m < M; m++) {
                for (n = 0; n < N; n++)
                    s[n] = string.Format("{0,12:F6}", 1000 * rnd.NextDouble());
                Table.Rows.Add(s);
            }
            dgv.DataSource = Table;
            //Text = dgv.ColumnCount.ToString();
            Controls.Add(dgv);
        }
    }
}