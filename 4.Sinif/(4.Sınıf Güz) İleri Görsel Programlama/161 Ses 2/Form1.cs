using System;
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

        OpenFileDialog ofd = new OpenFileDialog();
        SoundPlayer ses = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"C:\Windows\Media";
            ofd.Filter = "WAV files (*.wav)|*.wav";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ses.Stop();
            if (ofd.ShowDialog() == DialogResult.OK)
                ses.SoundLocation = Text = ofd.FileName;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ses.Stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ses.Play();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ses.PlayLooping();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
        }
    }
}