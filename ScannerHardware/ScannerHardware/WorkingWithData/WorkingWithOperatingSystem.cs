using MySql.Data.MySqlClient;
using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.WorkingWithData
{
    class WorkingWithOperatingSystem
    {
        private OperatingSystemPC os;
        public OperatingSystemPC readOperatingSystem()
        {
            os = new OperatingSystemPC();
            var queryObj = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>().First();

            os.Caption = ((string)queryObj["Caption"]).Trim();
            os.Version = (string)queryObj["Version"];
            os.Architecture = (string)queryObj["OSArchitecture"];
            os.SerialNumber = (string)queryObj["SerialNumber"];
            os.BuildNumber = ((string)queryObj["BuildNumber"]).ToUpper();

            return os;
        }

        public void insertOperatingSystem(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            String queryString = "INSERT INTO operatingsystem (name_OS, version__OS, bit_width, serialnumber_OS, number_package, id_PC)" +
  " VALUES ('" + os.Caption + "',' " + os.Version + "',' " + os.Architecture + "', '" + os.SerialNumber + "','" + os.BuildNumber + "', " + idPersonalComputer + ")";
            connect.runningQuery(queryString);
            connect.getConnection().Close();
        }
    }
}
