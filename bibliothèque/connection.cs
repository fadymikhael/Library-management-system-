using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bibliothèque
{
    class connection
    {
        private static string connectionString = "server=;port=;Database=;Uid=;password=";
        private static MySqlConnection maConnection = new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; set => maConnection = value; }
    }
}
