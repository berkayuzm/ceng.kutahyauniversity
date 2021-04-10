using System;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isVowel(char harf)
        {
            harf = char.ToUpper(harf);
            char[] chrs = { 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            foreach (char chr in chrs)
                if (chr == harf) return true;
            return false;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            int i, n = s.Length;
            string str = null;
            for (i = 0; i < n; i++)
            {
                if (isVowel(s[i]))
                {
                    if (i > 0) if (isVowel(s[i - 1])) str += '-';
                }
                else if (s[i] != ' ')
                {
                    if (i > 0 && i < n - 1)
                        if (isVowel(s[i + 1]) && s[i - 1] != ' ') str += '-';
                }
                str += s[i];
            }
            richTextBox2.Text = str;
        }

        private void RichTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hasan TEMURTAŞ";
        }
    }
}