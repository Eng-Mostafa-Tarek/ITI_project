namespace final_windows
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataStore.Staffs.Add(new Staff
            {
                StaffID = 1,
                Name = "Admin",
                Username = "admin",
                Password = "1234"
            });

            using (LoginForm login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(login.LoggedStaff));
                }
            }
        }
    }
}