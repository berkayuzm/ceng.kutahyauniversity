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

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DataGridView dgv = new DataGridView();
            dgv.Font = new Font("Consolas", 14f, FontStyle.Bold);
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersWidth = 50;
            //dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersHeight = 40;
            dgv.AllowUserToAddRows = false;
            dgv.RowTemplate.Height = 30;
            dgv.ReadOnly = true;
            int m, n, M = 100, N = 5;
            dgv.RowCount = M;
            dgv.ColumnCount = N;
            for (n = 0; n < N; n++) {
                dgv.Columns[n].Width = 145;
                //dgv.Columns[n].Name = "Col" + (n + 1).ToString();
                dgv.Columns[n].HeaderText = (n + 1).ToString() + ".Sütun";
                for (m = 0; m < M; m++)
                    dgv[n,m].Value = string.Format("{0,12:F6}",
                        1000 * rnd.NextDouble());
            }
            Controls.Add(dgv);
        }
    }
}