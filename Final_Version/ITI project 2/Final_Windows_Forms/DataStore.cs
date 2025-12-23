using Microsoft.Data.SqlClient;

namespace final_windows
{
    public static class DataStore
    {
        // التعديل هنا: غيرنا الـ Data Source ليكون اسم السيرفر الخاص بك (MOSTAFA\SQLEXPRESS)
        // وغيرنا الـ Initial Catalog ليتناسب مع اسم قاعدة البيانات (LibraryDB)
        public static string ConnectionString = @"Data Source=MOSTAFA\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        // تخزين بيانات الموظف اللي سجل دخوله عشان نستخدمها في عمليات الاستعارة
        public static int LoggedStaffID;
        public static string LoggedStaffName = "";
    }
}