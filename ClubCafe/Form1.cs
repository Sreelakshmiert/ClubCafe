namespace ClubCafe
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "ClubCafe@Admin" && Pass_word.Text == "123456")
            {
                DashBoard ds = new DashBoard("Admin");
                
                ds.Show();
               
                this.Hide();
                
            }
        }

        private void GuestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard ds = new DashBoard("Guest");
            ds.Show();
            this.Hide();
        }

        private void Pass_word_TextChanged(object sender, EventArgs e)
        {

        }
    }
}