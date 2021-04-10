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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.Items.Add("İbrahim Esen", 2);
            item.SubItems.AddRange(new string[] { "Elazığ", "0", "Java" });
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Tiles":
                    listView1.View = View.Tile;
                    break;
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "Large Icons":
                    listView1.View = View.LargeIcon;
                    break;
                case "Small Icons":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                default:
                    listView1.View = View.Tile;
                    break;
            }
        }
    }
}