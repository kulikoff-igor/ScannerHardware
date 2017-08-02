using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class PhysicalMemoryPC
    {
        private String manufacturer;
        private String partNumber;
        private String capacity;
        private String speed;
        private String serialNumber;

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public String Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public String Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public String PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        public String Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
    }
}
