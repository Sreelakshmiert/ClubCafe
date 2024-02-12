using ClubCafe.AllUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubCafe
{
    public partial class DashBoard : Form
    {
      

        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                AddItem.Hide();
                UpdateItem.Hide();
                RemoveItem.Hide();

            }
            else if (user == "Admin")
            {
                AddItem.Show();
                UpdateItem.Show();
                RemoveItem.Show();
            }
        }


        private void Close_Click(object sender, EventArgs e)
        {
           
            uC_AddItem1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_welcome1.BringToFront();
            uC_welcome1.Visible = true;
            AddItem.Show();
            UpdateItem.Show();
            RemoveItem.Show();
            PlaceOrder.Show();
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_page fm = new Login_page();
            this.Hide();
            fm.Show();
        }




        private void AddItem_Click(object sender, EventArgs e)
        {
            uC_welcome1.Visible = false;
            uC_AddItem1.BringToFront();
            uC_AddItem1.Visible = true;
            PlaceOrder.Hide();
            UpdateItem.Hide();
            RemoveItem.Hide();



        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
           // uC_AddItem1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_welcome1.BringToFront();
            uC_welcome1.Visible = true;

        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            uC_welcome1.Visible=false;
            uC_PlaceOrder1.BringToFront();
            uC_PlaceOrder1.Visible = true;
            AddItem.Hide();
            UpdateItem.Hide();
            RemoveItem.Hide();
        }
    }
}
