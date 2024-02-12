namespace ClubCafe
{
    partial class Login_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            Logo = new PictureBox();
            user_name = new Label();
            Password = new Label();
            Pass_word = new TextBox();
            UserName = new TextBox();
            Cafe_Name = new TextBox();
            GuestLink = new LinkLabel();
            LoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackgroundImageLayout = ImageLayout.None;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(119, 131);
            Logo.Margin = new Padding(0);
            Logo.Name = "Logo";
            Logo.Size = new Size(162, 169);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.Location = new Point(47, 358);
            user_name.Name = "user_name";
            user_name.Size = new Size(82, 20);
            user_name.TabIndex = 1;
            user_name.Text = "User Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(47, 434);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // Pass_word
            // 
            Pass_word.BackColor = SystemColors.ButtonFace;
            Pass_word.Location = new Point(138, 431);
            Pass_word.Name = "Pass_word";
            Pass_word.PasswordChar = '*';
            Pass_word.Size = new Size(178, 27);
            Pass_word.TabIndex = 4;
            Pass_word.TextChanged += Pass_word_TextChanged;
            // 
            // UserName
            // 
            UserName.BackColor = SystemColors.ButtonFace;
            UserName.Location = new Point(138, 351);
            UserName.Name = "UserName";
            UserName.Size = new Size(178, 27);
            UserName.TabIndex = 3;
            // 
            // Cafe_Name
            // 
            Cafe_Name.BackColor = SystemColors.ButtonFace;
            Cafe_Name.Font = new Font("Kunstler Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Cafe_Name.ForeColor = SystemColors.ControlText;
            Cafe_Name.Location = new Point(92, 39);
            Cafe_Name.Name = "Cafe_Name";
            Cafe_Name.Size = new Size(224, 55);
            Cafe_Name.TabIndex = 5;
            Cafe_Name.Text = "Club Cafe";
            Cafe_Name.TextAlign = HorizontalAlignment.Center;
            // 
            // GuestLink
            // 
            GuestLink.ActiveLinkColor = Color.Black;
            GuestLink.AutoSize = true;
            GuestLink.BorderStyle = BorderStyle.Fixed3D;
            GuestLink.LinkBehavior = LinkBehavior.NeverUnderline;
            GuestLink.LinkColor = Color.FromArgb(64, 0, 0);
            GuestLink.Location = new Point(138, 574);
            GuestLink.Margin = new Padding(0);
            GuestLink.Name = "GuestLink";
            GuestLink.Size = new Size(129, 22);
            GuestLink.TabIndex = 7;
            GuestLink.TabStop = true;
            GuestLink.Text = "Continue as Guest";
            GuestLink.LinkClicked += GuestLink_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ControlDarkDark;
            LoginButton.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.ButtonHighlight;
            LoginButton.Location = new Point(119, 512);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(162, 37);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(406, 632);
            Controls.Add(GuestLink);
            Controls.Add(LoginButton);
            Controls.Add(Cafe_Name);
            Controls.Add(Pass_word);
            Controls.Add(UserName);
            Controls.Add(Password);
            Controls.Add(user_name);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_page";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label user_name;
        private Label Password;
        private TextBox Pass_word;
        private TextBox UserName;
        private TextBox Cafe_Name;
        private Button radioButton2;
        private LinkLabel GuestLink;
        private Button LoginButton;
        
    }
}