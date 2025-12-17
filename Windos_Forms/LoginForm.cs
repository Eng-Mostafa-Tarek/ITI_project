using System.Linq;

namespace final_windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); 
        }
        public Staff? LoggedStaff { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var staff = DataStore.Staffs.FirstOrDefault(s => s.Username == txtUsername.Text && s.Password == txtPassword.Text);

            if (staff != null)
            {
                LoggedStaff = staff;
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
    }

}
