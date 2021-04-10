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
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Ad", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Soyad", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("No", 200, HorizontalAlignment.Left);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sira = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sira].SubItems.Add(textBox2.Text);
            listView1.Items[sira].SubItems.Add(textBox3.Text);

            listView1.Items[sira].SubItems[2].Text = "Hasan";


            //string[] insan = { "Umut", "Coşkun" };
            //ListViewItem Kullanici = new ListViewItem(insan);
            //ListView1.Items.Add(Kullanici);

            //ListView1.Items.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int yer = listView1.Items.Count;
                listView1.Items.Add("Hasan1");
                listView1.Items[yer].SubItems.Add("Hasan2");
                listView1.Items[yer].SubItems.Add("Hasan3");
            }
        }
    }
}
/*
listView1.View = View.Details;
listView1.GridLines = true;
listView1.FullRowSelect = true;

//Add column header
listView1.Columns.Add("ProductName", 100);
listView1.Columns.Add("Price", 70);
listView1.Columns.Add("Quantity", 70);

//Add items in the listview
string[] arr = new string[4];
ListViewItem itm ;

//Add first item
arr[0] = "product_1";
arr[1] = "100";
arr[2] = "10";
itm = new ListViewItem(arr);
listView1.Items.Add(itm);

//Add second item
arr[0] = "product_2";
arr[1] = "200";
arr[2] = "20";
itm = new ListViewItem(arr);
listView1.Items.Add(itm);

string productName = null;
string price = null;
string quantity = null;

productName = listView1.SelectedItems[0].SubItems[0].Text;
price = listView1.SelectedItems[0].SubItems[1].Text;
quantity = listView1.SelectedItems[0].SubItems[2].Text;

MessageBox.Show (productName + " , " + price + " , " + quantity);
 */
