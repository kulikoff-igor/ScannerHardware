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
    class WorkingWithPhysicalMemory
    {
        private List<PhysicalMemoryPC> listPhysicalMemory;
        public List<PhysicalMemoryPC> readPhysicalMemory()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_PhysicalMemory");
            listPhysicalMemory = new List<PhysicalMemoryPC>();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                PhysicalMemoryPC item = new PhysicalMemoryPC();
                item.Manufacturer = queryObj["Manufacturer"].ToString();
                item.PartNumber = queryObj["PartNumber"].ToString();
                item.SerialNumber = queryObj["SerialNumber"].ToString();
                item.Capacity = queryObj["Capacity"].ToString();
                item.Speed = queryObj["Speed"].ToString();
                listPhysicalMemory.Add(item);
            }
            return listPhysicalMemory;
        }
        public void insertPhysicalMemory(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (PhysicalMemoryPC physicalMemory in listPhysicalMemory)
            {
                String queryString = "INSERT INTO physicalmemory (manufacturer, partNumber, capacity, speed, serialNumber, idPC)" +
      " VALUES ('" + physicalMemory.Manufacturer + "','" + physicalMemory.PartNumber + "','" + physicalMemory.Capacity + "','" + physicalMemory.Speed + "', '" + physicalMemory.SerialNumber + "', " + idPersonalComputer + ")";
                connect.runningQuery(queryString);
                connect.getConnection().Close();
            }
        }
    }
}
