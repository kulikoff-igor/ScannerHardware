using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class HardDiskPC
    {
        private String model;
        private String partitions;
        private String size;
        private String serialNumber;

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public String Size
        {
            get { return size; }
            set { size = value; }
        }

        public String Partitions
        {
            get { return partitions; }
            set { partitions = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
