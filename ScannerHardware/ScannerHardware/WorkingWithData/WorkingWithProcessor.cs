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
    class WorkingWithProcessor
    {
        private ProcessorPC processor;
        public ProcessorPC readProcessor()
        {
            processor = new ProcessorPC();
            var queryObj = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();

            processor.Model = (string)queryObj["Name"];
            processor.ProcessorId = (string)queryObj["ProcessorId"];
            processor.MaxClockSpeed = queryObj["MaxClockSpeed"].ToString();
            processor.L3CacheSize = queryObj["L3CacheSize"].ToString();
            processor.NumberOfCores = queryObj["NumberOfCores"].ToString();
            processor.NumberOfLogicalProcessors = queryObj["NumberOfLogicalProcessors"].ToString();

            return processor;
        }
        public void insertProcessor(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            String queryString = "INSERT INTO processor (modelCPU ,cash_storage_processor, frequency_processor, logical_core, phisical_core, serialnumber_processor, id_PC)" +
  " VALUES ('" + processor.Model + "','" + processor.L3CacheSize + "',' " + processor.MaxClockSpeed + "',' " + processor.NumberOfLogicalProcessors + "', '" + processor.NumberOfCores + "','" + processor.ProcessorId + "', " + idPersonalComputer + ")";
            connect.runningQuery(queryString);
            connect.getConnection().Close();
        }
    }
}
