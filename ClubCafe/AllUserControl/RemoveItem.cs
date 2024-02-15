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
    public partial class UC_RemoveItem : UserControl
    {
        Function fn = new Function();
        String query;

        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            del_label.Text = "How to remove item?";
            del_label.ForeColor = Color.Brown;
            loadData();

        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGrid_RemoveItem.DataSource = ds.Tables[0];
        }

      
        private void dataGrid_RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void del_label_Click_1(object sender, EventArgs e)
        {
            del_label.ForeColor = Color.Red;
            del_label.Text = "Click on the row to delete the item";
        }

        private void dataGrid_RemoveItem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item ?", "important message", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGrid_RemoveItem.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id = '" + id + "'";
                fn.SetData(query);
                loadData();
            }
        }

        private void Item_name_box_TextChanged_1(object sender, EventArgs e)
        {

            query = "select * from items where name like '" + Item_name_box.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGrid_RemoveItem.DataSource = ds.Tables[0];
        }
    }
}
