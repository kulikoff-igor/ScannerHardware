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
    class WorkingWithMotherboard
    {
        private MotherboardPC motherboard;
        public MotherboardPC readMotherboard()
        {
            motherboard = new MotherboardPC();
            var queryObj = new ManagementObjectSearcher("select * from Win32_BaseBoard").Get().Cast<ManagementObject>().First();

            motherboard.Product = ((string)queryObj["Product"]);
            motherboard.Manufacturer = (string)queryObj["Manufacturer"];
            motherboard.SerialNumber = (string)queryObj["SerialNumber"];
            
            return motherboard;
        }
        public void insertMotherboard(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            String queryString = "INSERT INTO motherboard (producer_motherboard, model_motherboard, serialnumber_motherboard, id_PC)" +
  " VALUES ('" + motherboard.Manufacturer + "',' " +motherboard.Product +"',' " + motherboard.SerialNumber+"', " + idPersonalComputer + ")";
           connect.runningQuery(queryString);
           connect.getConnection().Close();
        }
    }
}
