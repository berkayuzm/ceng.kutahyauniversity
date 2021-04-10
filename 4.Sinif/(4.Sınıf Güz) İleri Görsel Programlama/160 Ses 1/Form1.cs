using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //const string str = @"C:\Windows\Media";
        const string str = "C:\\Windows\\Media";
        SoundPlayer ses = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(str, "*.wav");
            foreach (string file in files) LBox.Items.Add(file);
        }

        private void LBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ses.Stop();
            ses.SoundLocation = LBox.SelectedItem.ToString();
            ses.Play();
        }
    }
}