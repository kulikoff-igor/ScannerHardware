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
    class WorkingWithService
    {
        private List<ServicePC> listService;
        public List<ServicePC> readService()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_Service");
            listService = new List<ServicePC>();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                ServicePC item = new ServicePC();
                item.ProcessId = queryObj["ProcessId"].ToString();
                item.DisplayName = queryObj["DisplayName"].ToString();
                item.PathName = queryObj["PathName"].ToString();
                item.State = queryObj["State"].ToString();
                listService.Add(item);
            }
            return listService;
        }
        public void insertService(int idPersonalComputer)
        {
            Console.WriteLine(listService.Count);
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (ServicePC service in listService)
            {
                
                String queryString = "INSERT INTO services (name_services, path_services, status_services, processID, id_PC)" +
      " VALUES ('" + service.DisplayName + "','" + service.PathName + "','" + service.State + "','" + service.ProcessId + "'," + idPersonalComputer + ")";
                connect.runningQuery(queryString);
                connect.getConnection().Close();
            }
        }
    }
}
