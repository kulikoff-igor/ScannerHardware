using MySql.Data.MySqlClient;
using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkingWithData
{
    class WorkingWithPersonalComputer
    {
        public int insertPersonalComputer(String fioEmployee, int inventoryNumber) {
            ConnectionDatabase connect = new ConnectionDatabase();
            int idPersonalComputer;
            MySqlConnection connection = connect.getConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = "createPersonalComputer";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@fio_employee", fioEmployee);
            command.Parameters["@fio_employee"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@inventory_namber", inventoryNumber);
            command.Parameters["@inventory_namber"].Direction = ParameterDirection.Input;

            command.Parameters.AddWithValue("@idPersonalComputer", MySqlDbType.Int32);
            command.Parameters["@idPersonalComputer"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            idPersonalComputer = (int)command.Parameters["@idPersonalComputer"].Value;

            return idPersonalComputer;
        }
    }
}
