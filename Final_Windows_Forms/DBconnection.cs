using Microsoft.Data.SqlClient; // لازم Microsoft مش System

namespace final_windows.DB
{
    internal class DbConnection // خليت حرف الـ b صغير عشان الـ Spelling
    {
        public static SqlConnection GetConnection()
        {
            // اتأكد إن السيرفر عندك هو "." أو اسم السيرفر بتاعك
            string connectionString = "Server=.;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";
            return new SqlConnection(connectionString);
        }
    }
}