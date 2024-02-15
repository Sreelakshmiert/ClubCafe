namespace ClubCafe.AllUserControl
{
    partial class UC_RemoveItem
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
            remove = new Label();
            Item_name_box = new TextBox();
            label2 = new Label();
            dataGrid_RemoveItem = new DataGridView();
            del_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_RemoveItem).BeginInit();
            SuspendLayout();
            // 
            // remove
            // 
            remove.AutoSize = true;
            remove.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            remove.Location = new Point(56, 69);
            remove.Name = "remove";
            remove.Size = new Size(166, 29);
            remove.TabIndex = 3;
            remove.Text = "Remove Item";
            // 
            // Item_name_box
            // 
            Item_name_box.Location = new Point(324, 154);
            Item_name_box.Multiline = true;
            Item_name_box.Name = "Item_name_box";
            Item_name_box.PlaceholderText = "Start Typing...";
            Item_name_box.Size = new Size(186, 41);
            Item_name_box.TabIndex = 13;
            Item_name_box.TextAlign = HorizontalAlignment.Center;
            Item_name_box.TextChanged += Item_name_box_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(350, 109);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 12;
            label2.Text = "Item Name";
            // 
            // dataGrid_RemoveItem
            // 
            dataGrid_RemoveItem.BackgroundColor = SystemColors.ButtonHighlight;
            dataGrid_RemoveItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_RemoveItem.Location = new Point(56, 229);
            dataGrid_RemoveItem.Name = "dataGrid_RemoveItem";
            dataGrid_RemoveItem.RowHeadersWidth = 51;
            dataGrid_RemoveItem.RowTemplate.Height = 29;
            dataGrid_RemoveItem.Size = new Size(722, 259);
            dataGrid_RemoveItem.TabIndex = 14;
            dataGrid_RemoveItem.CellClick += dataGrid_RemoveItem_CellClick_1;
            // 
            // del_label
            // 
            del_label.AutoSize = true;
            del_label.Font = new Font("MV Boli", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            del_label.Location = new Point(333, 522);
            del_label.Name = "del_label";
            del_label.Size = new Size(49, 22);
            del_label.TabIndex = 15;
            del_label.Text = "Label";
            del_label.Click += del_label_Click_1;
            // 
            // UC_RemoveItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(del_label);
            Controls.Add(dataGrid_RemoveItem);
            Controls.Add(Item_name_box);
            Controls.Add(label2);
            Controls.Add(remove);
            Name = "UC_RemoveItem";
            Size = new Size(838, 591);
            Load += RemoveItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_RemoveItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label remove;
        private TextBox Item_name_box;
        private Label label2;
        private DataGridView dataGrid_RemoveItem;
        private Label del_label;
    }
}
