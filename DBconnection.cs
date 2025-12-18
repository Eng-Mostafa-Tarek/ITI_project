using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_windows.DB
{
    internal class DBconnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server=localhost;database=LibraryDB;user=root;password=;root123";

            return new MySqlConnection(connectionString);
        }
    }
}


