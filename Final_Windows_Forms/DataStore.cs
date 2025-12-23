using Microsoft.Data.SqlClient;

namespace final_windows
{
    public static class DataStore
    {
        // تأكد أن Initial Catalog هو اسم قاعدة البيانات عندك في SQL Server
        public static string ConnectionString = "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        // تخزين بيانات الموظف اللي سجل دخوله عشان نستخدمها في عمليات الاستعارة
        public static int LoggedStaffID;
        public static string LoggedStaffName = "";
    }
}