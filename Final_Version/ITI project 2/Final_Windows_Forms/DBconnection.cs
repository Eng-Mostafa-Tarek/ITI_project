using Microsoft.Data.SqlClient;

namespace final_windows.DB
{
    internal class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            // تم تحديث اسم السيرفر بناءً على صورة Connection Properties الخاصة بك
            string connectionString = @"Server=MOSTAFA\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";
            return new SqlConnection(connectionString);
        }
    }
}