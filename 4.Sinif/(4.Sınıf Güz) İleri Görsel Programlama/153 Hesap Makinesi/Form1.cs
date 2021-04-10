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

        private void Button_Click(object sender, EventArgs e)
        {
            double x = 0, y, z = 0;
            try {
                x = double.Parse(textBox1.Text);
                y = double.Parse(textBox2.Text);
                switch ((sender as Button).Text) {
                    case   "+": z = x + y; break;
                    case   "*": z = x * y; break;
                    case   "-": z = x - y; break;
                    case   "/": z = x / y; break;
                    case "Log": z = Math.Log10(x); break;
                    case  "Ln": z = Math.Log(x); break;
                    case "Exp": z = Math.Exp(x); break;
                    case "Sin": z = Math.Sin(x); break;
                    case "Cos": z = Math.Cos(x); break;
                    case "Tan": z = Math.Tan(x); break;
                    case "Kök": z = Math.Pow(x, 0.5); break;
                    case "Üst": z = Math.Pow(x, y); break;
                }
                textBox3.Text = z.ToString();
            }
            catch (DivideByZeroException hata)
            {
                MessageBox.Show("Sıfıra Bölmeye Hatası.\n" + hata.Message);
            }
            catch (OverflowException hata)
            {
                if (x < 0)
                    MessageBox.Show("Negatif Sayıyla Bu İşlemi Yapılmaz.\n"
                        + hata.Message);
                else
                    MessageBox.Show("Sayılar Çok Büyük\n" + hata.Message);
            }
            catch (FormatException hata)
            {
                MessageBox.Show("Sayı Giriniz.\n" + hata.Message);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Oluştu.\r\n" + hata.Message);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}