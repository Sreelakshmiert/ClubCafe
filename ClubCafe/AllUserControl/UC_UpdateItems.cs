using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubCafe.AllUserControl
{
    public partial class UC_UpdateItems : UserControl
    {

        Function fn = new Function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }


        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();

        }


        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            Datagrid_UpdateItem.DataSource = ds.Tables[0];
        }

       
        private void Item_name_box_TextChanged(object sender, EventArgs e)
        {

            query = "select * from items where name like '" + Item_name_box.Text + "%'";
            DataSet ds = fn.getData(query);
            Datagrid_UpdateItem.DataSource = ds.Tables[0];

        }
        int id;

        private void Datagrid_UpdateItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Datagrid_UpdateItem.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(Datagrid_UpdateItem.Rows[e.RowIndex].Cells[0].Value.ToString());
                String category = Datagrid_UpdateItem.Rows[e.RowIndex].Cells[2].Value.ToString();
                String name = Datagrid_UpdateItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(Datagrid_UpdateItem.Rows[e.RowIndex].Cells[3].Value.ToString());

                category_box.Text = category;
                ItemName_box.Text = name;
                Price_box.Text = price.ToString();
            }
            else
            {
                id = 0;
            }
            

        }
        private void Update_button_Click(object sender, EventArgs e)
        {

            query = "update items set name = '" + ItemName_box.Text + "'" +
                ",category ='" + category_box.Text + "',price = '" + Price_box.Text + "'" +
                " where id =" + id + "";
            fn.SetData(query);
            loadData();

            ItemName_box.Clear();
            Price_box.Clear();
            category_box.Clear();
        }
    }
}
