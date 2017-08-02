using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkWithDatabase
{
    class ConnectionDatabase
    {
        private MySqlConnection connection;
        public ConnectionDatabase()
        {
            IniFile ini = new IniFile("config.ini");

            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = ini.ReadINI("Config_BD", "url");
            mysqlCSB.Database = ini.ReadINI("Config_BD", "name");
            mysqlCSB.UserID = ini.ReadINI("Config_BD", "user");
            mysqlCSB.Password = ini.ReadINI("Config_BD", "pass");
            connection = new MySqlConnection();
            connection.ConnectionString = mysqlCSB.ConnectionString;
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public MySqlDataReader runningQuery(String queryString)
        {
            MySqlCommand command = new MySqlCommand(queryString, connection);

            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            //connection.Close();
            return reader;

        }
    }
}
