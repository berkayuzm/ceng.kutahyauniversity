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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                string s = Ofd.FileName;
                listBox1.Items.Add(s);
                listBox1.Items.Add("Dosyanın Tam Yolu : " + Path.GetFullPath(s));
                listBox1.Items.Add("Bulunduğu Klasör  : " + Path.GetDirectoryName(s));
                listBox1.Items.Add("Dosya Adı         : " + Path.GetFileName(s));
                listBox1.Items.Add("Dosya Uzantısı    : " + Path.GetExtension(s));
                listBox1.Items.Add("Dosya Uzantısız   : " + Path.GetFileNameWithoutExtension(s));
                listBox1.Items.Add("Kök Dizin         : " + Path.GetPathRoot(s));
                listBox1.Items.Add("Uzantısı Var Mı?  : " + Path.HasExtension(s));
                listBox1.Items.Add("------------------------------------------------");
            }
        }
    }
}