using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        MessageBoxButtons bTip;
        MessageBoxIcon iTip;
        string iStr;

        private void Form1_Load(object sender, EventArgs e)
        {
            rB1.Text = "Ok";
            rB2.Text = "OKCancel";
            rB3.Text = "RetryCancel";
            rB4.Text = "YesNo";
            rB5.Text = "YesNoCancel";
            rB6.Text = "AbortRetryIgnore";
            rB7.Text = "None";
            rB8.Text = "Error";
            rB9.Text = "Information";
            rB10.Text = "Question";
            rB11.Text = "Warning";
            rB1.Checked = true;
            rB7.Checked = true;
            label1.ResetText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Mesaj Kutusu", iStr, bTip, iTip);
            switch (durum)
            {
                case DialogResult.OK:
                    label1.Text = "Tamam Butonuna Basıldı";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "İptal Butonuna Basıldı";
                    break;
                case DialogResult.Abort:
                    label1.Text = "Durdur Butonuna Basıldı";
                    break;
                case DialogResult.Retry:
                    label1.Text = "Yeniden Dene Butonuna Basıldı";
                    break;
                case DialogResult.Ignore:
                    label1.Text = "Yoksay Butonuna Basıldı";
                    break;
                case DialogResult.Yes:
                    label1.Text = "Evet Butonuna Basıldı";
                    break;
                case DialogResult.No:
                    label1.Text = "Hayır Butonuna Basıldı";
                    break;
            }
        }

        private void BT_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "rB1":
                    bTip = MessageBoxButtons.OK;
                    break;
                case "rB2":
                    bTip = MessageBoxButtons.OKCancel;
                    break;
                case "rB3":
                    bTip = MessageBoxButtons.RetryCancel;
                    break;
                case "rB4":
                    bTip = MessageBoxButtons.YesNo;
                    break;
                case "rB5":
                    bTip = MessageBoxButtons.YesNoCancel;
                    break;
                case "rB6":
                    bTip = MessageBoxButtons.AbortRetryIgnore;
                    break;
            }
        }

        private void IT_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "rB7":
                    iTip = MessageBoxIcon.None;
                    iStr = "Hiç";
                    break;
                case "rB8":
                    iTip = MessageBoxIcon.Error;
                    iStr = "Hata";
                    break;
                case "rB9":
                    iTip = MessageBoxIcon.Information;
                    iStr = "Bilgi";
                    break;
                case "rB10":
                    iTip = MessageBoxIcon.Question;
                    iStr = "Soru";
                    break;
                case "rB11":
                    iTip = MessageBoxIcon.Warning;
                    iStr = "Uyarı";
                    break;
            }
        }
    }
}