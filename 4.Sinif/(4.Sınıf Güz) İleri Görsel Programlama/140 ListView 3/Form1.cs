using System;
using System.IO;
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
            textBox1.ResetText();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Gerilim Değeri", 250, HorizontalAlignment.Left);
            listView1.Columns.Add("Tarih", 250, HorizontalAlignment.Right);
            listView1.Columns.Add("Saat", 100, HorizontalAlignment.Right);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            int n = listView1.Items.Count;
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.TextLength > 0)
            {
                listView1.Items.Add(textBox1.Text);
                listView1.Items[n].SubItems.Add(tarih.ToLongDateString());
                listView1.Items[n].SubItems.Add(tarih.ToLongTimeString());
                textBox1.ResetText();
                textBox1.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = listView1.Items.Count;
            if (n == 0)
            {
                MessageBox.Show("Kaydedilecek Veri Yok", "Bilgi");
                return;
            }
            string str = @"..\..\dosya.txt";
            StreamWriter sw = File.AppendText(str);
            for (int i = 0; i < n; i++)
            {
                str = listView1.Items[i].SubItems[0].Text;
                sw.Write("{0,30}", str);
                str = listView1.Items[i].SubItems[1].Text;
                sw.Write("{0,30}", str);
                str = listView1.Items[i].SubItems[2].Text;
                sw.Write("{0,15}", str);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Dosyaya İlave Edildi", "Bilgi");
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) Button1_Click(sender, e);
        }
    }
}