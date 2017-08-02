using MySql.Data.MySqlClient;
using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkingWithData
{
    class WorkingWithEmployeers
    {
        public List<String> searchListEmployeers(String nameDepartament)
        {
            List<String> listEmployeers = new List<string>();
            ConnectionDatabase connect = new ConnectionDatabase();
            String queryString = "SELECT  employee.fio_employee FROM employee  INNER JOIN department  ON employee.id_department = department.id_department WHERE department.department_name = '" + nameDepartament + "'";
            MySqlDataReader reader;
            reader = connect.runningQuery(queryString);
            while (reader.Read())
            {
                listEmployeers.Add(reader.GetString(0));
            }
            connect.getConnection().Close();
            return listEmployeers;
        }
    }
}
