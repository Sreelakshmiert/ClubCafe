using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubCafe
{
    public partial class UC_AddItem : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_AddItem()
        {
            InitializeComponent();
        }



        private void Add_New_Item_Click(object sender, EventArgs e)
        {


            query = "insert into items(name,category,price) values " +
           "('" + Item_NameBox.Text + "','" + Category_box.Text +
           "','" + Price_box.Text + "')";

            fn.SetData(query);

            ClearAll();
        }

        public void ClearAll()
        {
            Category_box.SelectedIndex = -1;
            Item_NameBox.Clear();
            Price_box.Clear();
        }

        private void UC_AddItem_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Category_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
