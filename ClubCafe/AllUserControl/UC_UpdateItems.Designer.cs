namespace ClubCafe.AllUserControl
{
    partial class UC_UpdateItems
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
            update = new Label();
            Item_name_box = new TextBox();
            label2 = new Label();
            ItemName_box = new TextBox();
            label1 = new Label();
            category_box = new TextBox();
            label3 = new Label();
            Price_box = new TextBox();
            label4 = new Label();
            Datagrid_UpdateItem = new DataGridView();
            Update_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Datagrid_UpdateItem).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.AutoSize = true;
            update.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(61, 64);
            update.Name = "update";
            update.Size = new Size(161, 29);
            update.TabIndex = 2;
            update.Text = "Update Item";
            // 
            // Item_name_box
            // 
            Item_name_box.Location = new Point(602, 111);
            Item_name_box.Multiline = true;
            Item_name_box.Name = "Item_name_box";
            Item_name_box.PlaceholderText = "Start Typing...";
            Item_name_box.Size = new Size(186, 41);
            Item_name_box.TabIndex = 11;
            Item_name_box.TextAlign = HorizontalAlignment.Center;
            Item_name_box.TextChanged += Item_name_box_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(632, 64);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 10;
            label2.Text = "Item Name";
            // 
            // ItemName_box
            // 
            ItemName_box.Location = new Point(338, 433);
            ItemName_box.Multiline = true;
            ItemName_box.Name = "ItemName_box";
            ItemName_box.Size = new Size(186, 41);
            ItemName_box.TabIndex = 17;
            ItemName_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(69, 391);
            label1.Name = "label1";
            label1.Size = new Size(106, 29);
            label1.TabIndex = 16;
            label1.Text = "Category";
            // 
            // category_box
            // 
            category_box.Location = new Point(61, 433);
            category_box.Multiline = true;
            category_box.Name = "category_box";
            category_box.Size = new Size(186, 41);
            category_box.TabIndex = 19;
            category_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(356, 391);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 18;
            label3.Text = "Item Name";
            // 
            // Price_box
            // 
            Price_box.Location = new Point(580, 433);
            Price_box.Multiline = true;
            Price_box.Name = "Price_box";
            Price_box.Size = new Size(186, 41);
            Price_box.TabIndex = 21;
            Price_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(632, 391);
            label4.Name = "label4";
            label4.Size = new Size(65, 29);
            label4.TabIndex = 20;
            label4.Text = "Price";
            // 
            // Datagrid_UpdateItem
            // 
            Datagrid_UpdateItem.BackgroundColor = SystemColors.Control;
            Datagrid_UpdateItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagrid_UpdateItem.Location = new Point(61, 179);
            Datagrid_UpdateItem.Name = "Datagrid_UpdateItem";
            Datagrid_UpdateItem.RowHeadersWidth = 51;
            Datagrid_UpdateItem.RowTemplate.Height = 29;
            Datagrid_UpdateItem.Size = new Size(727, 188);
            Datagrid_UpdateItem.TabIndex = 22;
            Datagrid_UpdateItem.CellClick += Datagrid_UpdateItem_CellClick;
            // 
            // Update_button
            // 
            Update_button.AutoEllipsis = true;
            Update_button.BackColor = SystemColors.ControlDarkDark;
            Update_button.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Update_button.ForeColor = SystemColors.Control;
            Update_button.Location = new Point(349, 512);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(141, 44);
            Update_button.TabIndex = 23;
            Update_button.Text = "Update Item";
            Update_button.UseVisualStyleBackColor = false;
            Update_button.Click += Update_button_Click;
            // 
            // UC_UpdateItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Update_button);
            Controls.Add(Datagrid_UpdateItem);
            Controls.Add(Price_box);
            Controls.Add(label4);
            Controls.Add(category_box);
            Controls.Add(label3);
            Controls.Add(ItemName_box);
            Controls.Add(label1);
            Controls.Add(Item_name_box);
            Controls.Add(label2);
            Controls.Add(update);
            Name = "UC_UpdateItems";
            Size = new Size(838, 591);
            Load += UC_UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)Datagrid_UpdateItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label update;
        private TextBox Item_name_box;
        private Label label2;
        private TextBox ItemName_box;
        private Label label1;
        private TextBox category_box;
        private Label label3;
        private TextBox Price_box;
        private Label label4;
        private DataGridView Datagrid_UpdateItem;
        private Button Update_button;
    }
}
