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

        ColorDialog cDialog;
        FontDialog fDialog;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cDialog = new ColorDialog();
            cDialog.FullOpen = true;
            fDialog = new FontDialog();
            textBox1.Text = "Kütahya Dumlupınar Üniversitesi\r\n"
                + "Mühendislik Fakültesi\r\n"
                + "Bilgisayar Mühendisliği Bölümü\r\n\r\n"
                + "Hasan TEMURTAŞ\r\n";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (fDialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = fDialog.Font;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (cDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = cDialog.Color;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font,
                textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font,
                textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font,
                textBox1.Font.Style ^ FontStyle.Underline);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0) textBox1.Cut();
            else MessageBox.Show("Seçili Alan Yok", "Mesaj Kutusu");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0) textBox1.Copy();
            else MessageBox.Show("Seçili Alan Yok", "Mesaj Kutusu");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
    }
}