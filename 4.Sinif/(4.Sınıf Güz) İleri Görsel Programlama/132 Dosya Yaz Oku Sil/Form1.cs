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

        string fName = @"..\..\Dosya.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = File.Exists(fName) ? "Dosya Var" : "Dosya Yok";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Dosya Var";
            StreamWriter f = File.AppendText(fName);
            f.WriteLine("İleri Görsel Programlama Dersi");
            f.WriteLine("C# Programlama Dili");
            f.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(fName)) {
                StreamReader f = File.OpenText(fName);
                richTextBox1.Text = f.ReadToEnd();
                f.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(fName)) {
                File.Delete(fName);
                richTextBox1.Clear();
                label1.Text = "Dosya Yok";
            }
        }
    }
}