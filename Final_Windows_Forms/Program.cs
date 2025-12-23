using System;
using System.Windows.Forms;

namespace final_windows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // We start with the LoginForm. If login is successful, 
            // the LoginForm will open the MainForm.
            Application.Run(new LoginForm());
        }
    }
}