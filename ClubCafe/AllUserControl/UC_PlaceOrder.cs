using DGVPrinterHelper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;



namespace ClubCafe.AllUserControl
{
    public partial class UC_PlaceOrder : UserControl
    {
        Function fn = new Function();

        String query;
        public UC_PlaceOrder()
        {


            InitializeComponent();
        }



        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'";



            showItemlist(query);

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'and name like  '" + textSearch.Text + "%'";
            showItemlist(query);

        }
        private void showItemlist(string query)
        {
            ItemView.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ItemView.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }




        }

        private void ItemView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quantity_UpDown1.ResetText();
            Total_box.Clear();
            String text = ItemView.GetItemText(ItemView.SelectedItem);
            Item_Name.Text = text;

            query = "select price from items where name = '" + text + "'";
            DataSet ds = fn.getData(query);

            Price_Box.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void Quantity_UpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(Quantity_UpDown1.Value.ToString());
            Int64 price = Int64.Parse(Price_Box.Text);

            Total_box.Text = (quan * price).ToString();
        }


        protected int n, total = 0;
        private void Add_To_Cart_Click(object sender, EventArgs e)
        {
            if (Total_box.Text != "0" && Total_box.Text != "")
            {
                n = Place_order_datagrid.Rows.Add();
                Place_order_datagrid.Rows[n].Cells[0].Value = Item_Name.Text;
                Place_order_datagrid.Rows[n].Cells[1].Value = Price_Box.Text;
                Place_order_datagrid.Rows[n].Cells[2].Value = Quantity_UpDown1.Value;
                Place_order_datagrid.Rows[n].Cells[3].Value = Total_box.Text;

                total += int.Parse(Total_box.Text);

                Grand_Toatal.Text = "Rs.  " + total;
                Quantity_UpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show("Minimum quantity is 1", "information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void Place_order_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          amount = int.Parse(Place_order_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString());
          
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
                Place_order_datagrid.Rows.RemoveAt(this.Place_order_datagrid.
                    SelectedRows[0].Index);
            total -= amount;
            Grand_Toatal.Text = "Rs.  " + total;
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.CellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable amount :  " + Grand_Toatal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(Place_order_datagrid);


            total = 0;
            Place_order_datagrid.Rows.Clear();
            Grand_Toatal.Text = "Rs.  " + total;
        }
    }
}

    

