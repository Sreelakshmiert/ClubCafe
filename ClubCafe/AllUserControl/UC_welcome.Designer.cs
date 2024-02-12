namespace ClubCafe.AllUserControl
{
    partial class UC_welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_welcome));
            Welcome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Welcome).BeginInit();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.Image = (Image)resources.GetObject("Welcome.Image");
            Welcome.Location = new Point(3, 3);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(701, 492);
            Welcome.TabIndex = 0;
            Welcome.TabStop = false;
            Welcome.Click += pictureBox1_Click;
            // 
            // UC_welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Welcome);
            Name = "UC_welcome";
            Size = new Size(707, 495);
            ((System.ComponentModel.ISupportInitialize)Welcome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Welcome;
    }
}
