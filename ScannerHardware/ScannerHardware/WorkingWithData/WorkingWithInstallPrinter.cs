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
    class WorkingWithInstallPrinter
    {
        private List<InstallPrinterPC> listInstallPrinter;
        public List<InstallPrinterPC> readInstallPrinter()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Printer");
            listInstallPrinter = new List<InstallPrinterPC>();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                InstallPrinterPC item = new InstallPrinterPC();
                item.DeviceID = queryObj["DeviceID"].ToString();
                item.PortName = queryObj["PortName"].ToString();
                listInstallPrinter.Add(item);
            }
            return listInstallPrinter;
        }
        public void insertInstallPrinter(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (InstallPrinterPC installPrinter in listInstallPrinter)
            {
                
                String queryString = "INSERT INTO printer (model_printer, port_printer, id_PC)" +
      " VALUES ('" + installPrinter.DeviceID + "','" + installPrinter.PortName + "', " + idPersonalComputer + ")";
                connect.runningQuery(queryString);
                connect.getConnection().Close();
            }
        }

    }
}
