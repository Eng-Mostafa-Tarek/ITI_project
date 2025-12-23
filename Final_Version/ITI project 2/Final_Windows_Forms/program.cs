using System;
using System.Windows.Forms;

namespace final_windows
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //  √ﬂœ √‰ BookForm ÂÊ «”„ «·‘«‘… «· Ì  —Ìœ »œ∆Â«
            Application.Run(new LoginForm());
        }
    }
}