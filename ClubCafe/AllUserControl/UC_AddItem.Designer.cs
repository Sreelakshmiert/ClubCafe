namespace ClubCafe
{
    partial class UC_AddItem
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
            AddNewItem = new Label();
            Price = new Label();
            ItemName = new Label();
            Category = new Label();
            Add_New_Item = new Button();
            Category_box = new ComboBox();
            Item_NameBox = new TextBox();
            Price_box = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // AddNewItem
            // 
            AddNewItem.AutoSize = true;
            AddNewItem.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewItem.Location = new Point(312, 84);
            AddNewItem.Name = "AddNewItem";
            AddNewItem.Size = new Size(224, 37);
            AddNewItem.TabIndex = 0;
            AddNewItem.Text = "Add New Item";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Price.Location = new Point(136, 331);
            Price.Name = "Price";
            Price.Size = new Size(65, 29);
            Price.TabIndex = 1;
            Price.Text = "Price";
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            ItemName.Location = new Point(120, 258);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(134, 29);
            ItemName.TabIndex = 2;
            ItemName.Text = "Item Name";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.BackColor = SystemColors.ButtonFace;
            Category.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Category.Location = new Point(120, 177);
            Category.Name = "Category";
            Category.Size = new Size(106, 29);
            Category.TabIndex = 3;
            Category.Text = "Category";
            // 
            // Add_New_Item
            // 
            Add_New_Item.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Add_New_Item.Location = new Point(339, 472);
            Add_New_Item.Name = "Add_New_Item";
            Add_New_Item.Size = new Size(149, 49);
            Add_New_Item.TabIndex = 4;
            Add_New_Item.Text = "Add Item";
            Add_New_Item.UseVisualStyleBackColor = true;
            Add_New_Item.Click += Add_New_Item_Click;
            // 
            // Category_box
            // 
            Category_box.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Category_box.FormattingEnabled = true;
            Category_box.Items.AddRange(new object[] { "Indian Main course", "Aplitizers", "Rice", "Cool drinks" });
            Category_box.Location = new Point(421, 169);
            Category_box.Name = "Category_box";
            Category_box.Size = new Size(276, 37);
            Category_box.TabIndex = 5;
            Category_box.SelectedIndexChanged += Category_box_SelectedIndexChanged;
            // 
            // Item_NameBox
            // 
            Item_NameBox.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Item_NameBox.Location = new Point(421, 255);
            Item_NameBox.Name = "Item_NameBox";
            Item_NameBox.Size = new Size(276, 45);
            Item_NameBox.TabIndex = 6;
            // 
            // Price_box
            // 
            Price_box.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Price_box.Location = new Point(421, 331);
            Price_box.Name = "Price_box";
            Price_box.Size = new Size(276, 45);
            Price_box.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(801, 555);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // UC_AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(Price_box);
            Controls.Add(Item_NameBox);
            Controls.Add(Category_box);
            Controls.Add(Add_New_Item);
            Controls.Add(Category);
            Controls.Add(ItemName);
            Controls.Add(Price);
            Controls.Add(AddNewItem);
            Name = "UC_AddItem";
            Size = new Size(838, 591);
            Leave += UC_AddItem_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewItem;
        private Label Price;
        private Label ItemName;
        private Label Category;
        private Button Add_New_Item;
        private ComboBox Category_box;
        private TextBox Item_NameBox;
        private TextBox Price_box;
        private ComboBox comboBox1;
    }
}
