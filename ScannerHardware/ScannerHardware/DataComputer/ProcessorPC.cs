using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class ProcessorPC
    {
        private String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        private String l3CacheSize;

        public String L3CacheSize
        {
            get { return l3CacheSize; }
            set { l3CacheSize = value; }
        }
        private String maxClockSpeed;

        public String MaxClockSpeed
        {
            get { return maxClockSpeed; }
            set { maxClockSpeed = value; }
        }
        private String numberOfCores;

        public String NumberOfCores
        {
            get { return numberOfCores; }
            set { numberOfCores = value; }
        }
        private String numberOfLogicalProcessors;

        public String NumberOfLogicalProcessors
        {
            get { return numberOfLogicalProcessors; }
            set { numberOfLogicalProcessors = value; }
        }
        private String processorId;

        public String ProcessorId
        {
            get { return processorId; }
            set { processorId = value; }
        }
    }
}
