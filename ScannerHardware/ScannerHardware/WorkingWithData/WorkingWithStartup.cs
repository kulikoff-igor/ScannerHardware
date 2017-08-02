using MySql.Data.MySqlClient;
using ScannerHardware.DataComputer;
using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkingWithData
{
    class WorkingWithStartup
    {
        private List<StartupPC> listStartup;
        public List<StartupPC> readStartup()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_StartupCommand");
            listStartup = new List<StartupPC>();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                StartupPC item = new StartupPC();
                item.NameProgram = queryObj["Name"].ToString();
                item.Command = queryObj["Command"].ToString();
                listStartup.Add(item);
            }
            return listStartup;
        }
        public void insertStartup(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (StartupPC startup in listStartup)
            {
               
                String queryString = "INSERT INTO autoloading (name_autoloading, path_autoloading, id_PC)" +
      " VALUES ('" + startup.NameProgram + "','" + startup.Command + "', " + idPersonalComputer + ")";
                connect.runningQuery(queryString);
                connect.getConnection().Close();
            }
        }
    }
}
