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
    class WorkingWithHardDisk
    {
        private List<HardDiskPC> listHardDisk;
        public List<HardDiskPC> readHardDisk()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_DiskDrive");
            listHardDisk = new List<HardDiskPC>();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                HardDiskPC item = new HardDiskPC();
                item.Model = queryObj["Model"].ToString();
                item.Partitions = queryObj["Partitions"].ToString();
                item.SerialNumber = queryObj["SerialNumber"].ToString();
                try
                {
                    item.Size = queryObj["Size"].ToString();
                }
                catch (Exception e) {
                    item.Size = "0";
                }
                listHardDisk.Add(item);
            }
            return listHardDisk;
        }
        public void insertHardDisk(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (HardDiskPC hardDisk in listHardDisk)
            {
                
                String queryString = "INSERT INTO disk (model_disk, divide_disk, size_disk, serial_number_disk, id_PC)" +
      " VALUES ('" + hardDisk.Model + "','" + hardDisk.Partitions + "','" + hardDisk.Size + "', '" + hardDisk.SerialNumber + "', " + idPersonalComputer + ")";
               connect.runningQuery(queryString);
               connect.getConnection().Close();
            }
        }
    }
}
