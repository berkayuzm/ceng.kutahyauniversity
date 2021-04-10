using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public string Pcommand;
        public bool isOpen;

        OpenFileDialog ofd = new OpenFileDialog();

        public void Play(bool loop)
        {
            if (isOpen)
            {
                Pcommand = "play MediaFile";
                if (loop)
                    Pcommand += " REPEAT";
                mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ofd.Filter =
                "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            ofd.ShowDialog();
            if (ofd.FileName != "")
                textBox1.Text = ofd.FileName;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pcommand = "open \"" + textBox1.Text + "\" type mpegvideo alias MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = true;
            Play(true);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Pcommand = "close MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}