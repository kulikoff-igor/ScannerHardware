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
    class WorkingWithVideoController
    {
        private List<VideoControllerPC> listVideoController;
        public List<VideoControllerPC> readVideoController()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_VideoController");
            listVideoController = new List<VideoControllerPC>();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                VideoControllerPC item = new VideoControllerPC();
                item.Caption = queryObj["Caption"].ToString();
                item.AdapterCompatibility = queryObj["AdapterCompatibility"].ToString();
                item.AdapterRam = queryObj["AdapterRam"].ToString();
                item.VideoProcessor = queryObj["VideoProcessor"].ToString();
                item.DriverVersion = queryObj["DriverVersion"].ToString();
                listVideoController.Add(item);
            }
            return listVideoController;
        }
        public void insertVideoController(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (VideoControllerPC videoController in listVideoController)
            {
                
                String queryString = "INSERT INTO videocard (producer_videocard, model_videocard, size_videocard, processor_videocard, driver_videocard, id_PC)" +
      "VALUES ('" + videoController.AdapterCompatibility + "','" + videoController.Caption  + "','" + videoController.AdapterRam + "','" + videoController.VideoProcessor + "', '" + videoController.DriverVersion + "', " + idPersonalComputer + ")";
                connect.runningQuery(queryString);
                connect.getConnection().Close();
            }
        }
    }
}
