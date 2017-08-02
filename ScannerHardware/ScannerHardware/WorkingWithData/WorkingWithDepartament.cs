using MySql.Data.MySqlClient;
using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkingWithData
{
    class WorkingWithDepartament
    {
        public List<String> searchListDepartaments()
        {
            List<String> listDepartament = new List<string>();
            ConnectionDatabase connect = new ConnectionDatabase();
            String queryString = "SELECT  department.department_name FROM department";
            MySqlDataReader reader;
            reader = connect.runningQuery(queryString);
            while (reader.Read())
            {
                listDepartament.Add(reader.GetString(0));
            }
            connect.getConnection().Close();
            return listDepartament;
        }
    }
}
