namespace ClubCafe.AllUserControl
{
    partial class UC_PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            placeOrder = new Label();
            Category = new Label();
            comboCategory = new ComboBox();
            textSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Price_Box = new TextBox();
            Total_box = new TextBox();
            Item_Name = new TextBox();
            Quantity_UpDown1 = new NumericUpDown();
            Add_To_Cart = new Button();
            Place_order_datagrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            Remove_button = new Button();
            Print_button = new Button();
            Total = new Label();
            Grand_Toatal = new Label();
            ItemView = new ListBox();
            ((System.ComponentModel.ISupportInitialize)Quantity_UpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Place_order_datagrid).BeginInit();
            SuspendLayout();
            // 
            // placeOrder
            // 
            placeOrder.AutoSize = true;
            placeOrder.Font = new Font("MV Boli", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            placeOrder.Location = new Point(75, 30);
            placeOrder.Name = "placeOrder";
            placeOrder.Size = new Size(99, 22);
            placeOrder.TabIndex = 0;
            placeOrder.Text = "Place Order";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Category.Location = new Point(33, 72);
            Category.Name = "Category";
            Category.Size = new Size(106, 29);
            Category.TabIndex = 1;
            Category.Text = "Category";
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Cool drinks", "Indian Main course", "Aplitizers" });
            comboCategory.Location = new Point(33, 108);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(170, 28);
            comboCategory.TabIndex = 2;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(33, 161);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(170, 27);
            textSearch.TabIndex = 3;
            textSearch.Text = "Search";
            textSearch.TextAlign = HorizontalAlignment.Center;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(268, 30);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(559, 30);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 6;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(268, 134);
            label3.Name = "label3";
            label3.Size = new Size(108, 29);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(555, 134);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 8;
            label4.Text = "Total";
            // 
            // Price_Box
            // 
            Price_Box.Location = new Point(555, 76);
            Price_Box.Name = "Price_Box";
            Price_Box.Size = new Size(170, 27);
            Price_Box.TabIndex = 9;
            Price_Box.TextAlign = HorizontalAlignment.Center;
            // 
            // Total_box
            // 
            Total_box.Location = new Point(555, 183);
            Total_box.Name = "Total_box";
            Total_box.Size = new Size(170, 27);
            Total_box.TabIndex = 10;
            Total_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Item_Name
            // 
            Item_Name.Location = new Point(268, 76);
            Item_Name.Name = "Item_Name";
            Item_Name.Size = new Size(170, 27);
            Item_Name.TabIndex = 11;
            Item_Name.TextAlign = HorizontalAlignment.Center;
            // 
            // Quantity_UpDown1
            // 
            Quantity_UpDown1.Location = new Point(288, 184);
            Quantity_UpDown1.Name = "Quantity_UpDown1";
            Quantity_UpDown1.Size = new Size(88, 27);
            Quantity_UpDown1.TabIndex = 12;
            Quantity_UpDown1.ValueChanged += Quantity_UpDown1_ValueChanged;
            // 
            // Add_To_Cart
            // 
            Add_To_Cart.AutoEllipsis = true;
            Add_To_Cart.BackColor = SystemColors.ControlDarkDark;
            Add_To_Cart.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Add_To_Cart.ForeColor = SystemColors.Control;
            Add_To_Cart.Location = new Point(410, 227);
            Add_To_Cart.Name = "Add_To_Cart";
            Add_To_Cart.Size = new Size(141, 44);
            Add_To_Cart.TabIndex = 13;
            Add_To_Cart.Text = "Add To Cart";
            Add_To_Cart.UseVisualStyleBackColor = false;
            Add_To_Cart.Click += Add_To_Cart_Click;
            // 
            // Place_order_datagrid
            // 
            Place_order_datagrid.BorderStyle = BorderStyle.Fixed3D;
            Place_order_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Place_order_datagrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            Place_order_datagrid.Location = new Point(255, 277);
            Place_order_datagrid.Name = "Place_order_datagrid";
            Place_order_datagrid.RowHeadersWidth = 51;
            Place_order_datagrid.RowTemplate.Height = 29;
            Place_order_datagrid.Size = new Size(518, 195);
            Place_order_datagrid.TabIndex = 14;
            Place_order_datagrid.CellClick += Place_order_datagrid_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Unit Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Remove_button
            // 
            Remove_button.AutoEllipsis = true;
            Remove_button.BackColor = SystemColors.ControlDarkDark;
            Remove_button.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Remove_button.ForeColor = SystemColors.Control;
            Remove_button.Location = new Point(261, 522);
            Remove_button.Name = "Remove_button";
            Remove_button.Size = new Size(141, 44);
            Remove_button.TabIndex = 15;
            Remove_button.Text = "Remove";
            Remove_button.UseVisualStyleBackColor = false;
            Remove_button.Click += Remove_button_Click;
            // 
            // Print_button
            // 
            Print_button.AutoEllipsis = true;
            Print_button.BackColor = SystemColors.ControlDarkDark;
            Print_button.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Print_button.ForeColor = SystemColors.Control;
            Print_button.Location = new Point(632, 517);
            Print_button.Name = "Print_button";
            Print_button.Size = new Size(141, 44);
            Print_button.TabIndex = 16;
            Print_button.Text = "Print";
            Print_button.UseVisualStyleBackColor = false;
            Print_button.Click += Print_button_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Total.Location = new Point(439, 488);
            Total.Name = "Total";
            Total.Size = new Size(143, 29);
            Total.TabIndex = 17;
            Total.Text = "Grand Total";
            // 
            // Grand_Toatal
            // 
            Grand_Toatal.AutoSize = true;
            Grand_Toatal.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Grand_Toatal.Location = new Point(460, 533);
            Grand_Toatal.Name = "Grand_Toatal";
            Grand_Toatal.Size = new Size(91, 28);
            Grand_Toatal.TabIndex = 18;
            Grand_Toatal.Text = "Rs : 00";
            // 
            // ItemView
            // 
            ItemView.Cursor = Cursors.Hand;
            ItemView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemView.FormattingEnabled = true;
            ItemView.ItemHeight = 28;
            ItemView.Location = new Point(33, 236);
            ItemView.Name = "ItemView";
            ItemView.Size = new Size(168, 312);
            ItemView.Sorted = true;
            ItemView.TabIndex = 19;
            ItemView.SelectedIndexChanged += ItemView_SelectedIndexChanged;
            // 
            // UC_PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemView);
            Controls.Add(Grand_Toatal);
            Controls.Add(Total);
            Controls.Add(Print_button);
            Controls.Add(Remove_button);
            Controls.Add(Place_order_datagrid);
            Controls.Add(Add_To_Cart);
            Controls.Add(Quantity_UpDown1);
            Controls.Add(Item_Name);
            Controls.Add(Total_box);
            Controls.Add(Price_Box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSearch);
            Controls.Add(comboCategory);
            Controls.Add(Category);
            Controls.Add(placeOrder);
            Name = "UC_PlaceOrder";
            Size = new Size(838, 591);
            ((System.ComponentModel.ISupportInitialize)Quantity_UpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Place_order_datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label placeOrder;
        private Label Category;
        private ComboBox comboCategory;
        private TextBox textSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Price_Box;
        private TextBox Total_box;
        private TextBox Item_Name;
        private NumericUpDown Quantity_UpDown1;
        private Button Add_To_Cart;
        private DataGridView Place_order_datagrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button Remove_button;
        private Button Print_button;
        private Label Total;
        private Label Grand_Toatal;
        private ListBox ItemView;
    }
}
