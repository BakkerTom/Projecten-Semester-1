using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLite_Test
{
    class Connection
    {
        private static Connection self;
        private SQLiteConnection connection = new SQLiteConnection(
               "Data Source=C:/Users/Tom/Documents/Visual Studio 2015/Projects/SQLite Test/database.db;Version=3;");

        private Connection()
        {
            connection.Open();
        }

        public static Connection getInstance() {
            if (self == null)
            {
                self = new Connection();
            }
            return self;
        }

        public SQLiteConnection getConnection() {
            return connection;
        }
    }
}
