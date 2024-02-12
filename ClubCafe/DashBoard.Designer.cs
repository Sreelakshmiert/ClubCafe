namespace ClubCafe
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Options = new Panel();
            uC_AddItem1 = new UC_AddItem();
            logOut = new LinkLabel();
            close = new Button();
            AddItem = new Button();
            RemoveItem = new Button();
            UpdateItem = new Button();
            PlaceOrder = new Button();
            Welcome = new FlowLayoutPanel();
            uC_PlaceOrder1 = new AllUserControl.UC_PlaceOrder();
            uC_AddItem3 = new UC_AddItem();
            uC_welcome1 = new AllUserControl.UC_welcome();
            uC_AddItem2 = new UC_AddItem();
            Options.SuspendLayout();
            Welcome.SuspendLayout();
            SuspendLayout();
            // 
            // Options
            // 
            Options.BackColor = SystemColors.MenuBar;
            Options.Controls.Add(uC_AddItem1);
            Options.Controls.Add(logOut);
            Options.Controls.Add(close);
            Options.Controls.Add(AddItem);
            Options.Controls.Add(RemoveItem);
            Options.Controls.Add(UpdateItem);
            Options.Controls.Add(PlaceOrder);
            Options.ForeColor = SystemColors.WindowFrame;
            Options.Location = new Point(2, 3);
            Options.Name = "Options";
            Options.Size = new Size(257, 609);
            Options.TabIndex = 0;
            // 
            // uC_AddItem1
            // 
            uC_AddItem1.Location = new Point(255, 12);
            uC_AddItem1.Name = "uC_AddItem1";
            uC_AddItem1.Size = new Size(859, 597);
            uC_AddItem1.TabIndex = 4;
            // 
            // logOut
            // 
            logOut.AutoSize = true;
            logOut.BackColor = SystemColors.ControlDarkDark;
            logOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOut.LinkBehavior = LinkBehavior.NeverUnderline;
            logOut.LinkColor = Color.Snow;
            logOut.Location = new Point(78, 533);
            logOut.Name = "logOut";
            logOut.Size = new Size(86, 28);
            logOut.TabIndex = 0;
            logOut.TabStop = true;
            logOut.Text = "Log Out";
            logOut.LinkClicked += LogOut_LinkClicked;
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            close.ImageAlign = ContentAlignment.TopCenter;
            close.Location = new Point(10, 9);
            close.Name = "close";
            close.Size = new Size(37, 29);
            close.TabIndex = 0;
            close.Text = "<-";
            close.TextAlign = ContentAlignment.TopCenter;
            close.UseVisualStyleBackColor = true;
            close.Click += Close_Click;
            // 
            // AddItem
            // 
            AddItem.BackColor = SystemColors.GrayText;
            AddItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddItem.ForeColor = SystemColors.MenuBar;
            AddItem.Location = new Point(41, 136);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(163, 43);
            AddItem.TabIndex = 3;
            AddItem.Text = "Add Item";
            AddItem.UseVisualStyleBackColor = false;
            AddItem.Click += AddItem_Click;
            // 
            // RemoveItem
            // 
            RemoveItem.BackColor = SystemColors.GrayText;
            RemoveItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveItem.ForeColor = SystemColors.MenuBar;
            RemoveItem.Location = new Point(41, 313);
            RemoveItem.Name = "RemoveItem";
            RemoveItem.Size = new Size(163, 43);
            RemoveItem.TabIndex = 2;
            RemoveItem.Text = "Remove Item";
            RemoveItem.UseVisualStyleBackColor = false;
            // 
            // UpdateItem
            // 
            UpdateItem.BackColor = SystemColors.GrayText;
            UpdateItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateItem.ForeColor = SystemColors.MenuBar;
            UpdateItem.Location = new Point(41, 226);
            UpdateItem.Name = "UpdateItem";
            UpdateItem.Size = new Size(163, 43);
            UpdateItem.TabIndex = 1;
            UpdateItem.Text = "Update Item";
            UpdateItem.UseVisualStyleBackColor = false;
            // 
            // PlaceOrder
            // 
            PlaceOrder.BackColor = SystemColors.GrayText;
            PlaceOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PlaceOrder.ForeColor = SystemColors.MenuBar;
            PlaceOrder.Location = new Point(41, 54);
            PlaceOrder.Margin = new Padding(0);
            PlaceOrder.Name = "PlaceOrder";
            PlaceOrder.Size = new Size(163, 43);
            PlaceOrder.TabIndex = 0;
            PlaceOrder.Text = "Place Order";
            PlaceOrder.UseVisualStyleBackColor = false;
            PlaceOrder.Click += PlaceOrder_Click;
            // 
            // Welcome
            // 
            Welcome.BackColor = SystemColors.MenuBar;
            Welcome.Controls.Add(uC_PlaceOrder1);
            Welcome.Controls.Add(uC_AddItem3);
            Welcome.Controls.Add(uC_welcome1);
            Welcome.Controls.Add(uC_AddItem2);
            Welcome.ForeColor = SystemColors.Control;
            Welcome.Location = new Point(265, 12);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(838, 591);
            Welcome.TabIndex = 1;
            // 
            // uC_PlaceOrder1
            // 
            uC_PlaceOrder1.ForeColor = SystemColors.ControlText;
            uC_PlaceOrder1.Location = new Point(3, 3);
            uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            uC_PlaceOrder1.Size = new Size(835, 588);
            uC_PlaceOrder1.TabIndex = 5;
            // 
            // uC_AddItem3
            // 
            uC_AddItem3.ForeColor = SystemColors.ActiveCaptionText;
            uC_AddItem3.Location = new Point(3, 597);
            uC_AddItem3.Name = "uC_AddItem3";
            uC_AddItem3.Size = new Size(1048, 739);
            uC_AddItem3.TabIndex = 2;
            // 
            // uC_welcome1
            // 
            uC_welcome1.Location = new Point(3, 1342);
            uC_welcome1.Name = "uC_welcome1";
            uC_welcome1.Size = new Size(848, 588);
            uC_welcome1.TabIndex = 0;
            // 
            // uC_AddItem2
            // 
            uC_AddItem2.Location = new Point(3, 1936);
            uC_AddItem2.Name = "uC_AddItem2";
            uC_AddItem2.Size = new Size(1048, 739);
            uC_AddItem2.TabIndex = 1;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1115, 615);
            Controls.Add(Welcome);
            Controls.Add(Options);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            Options.ResumeLayout(false);
            Options.PerformLayout();
            Welcome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Options;
        private FlowLayoutPanel Welcome;
        private Button PlaceOrder;
        private Button AddItem;
        private Button RemoveItem;
        private Button UpdateItem;
        private Button close;
        private LinkLabel logOut;
        private AllUserControl.UC_welcome uC_welcome1;
        private UC_AddItem uC_AddItem1;
        private UC_AddItem uC_AddItem3;
        private UC_AddItem uC_AddItem2;
        private AllUserControl.UC_PlaceOrder uC_PlaceOrder1;
    }
}