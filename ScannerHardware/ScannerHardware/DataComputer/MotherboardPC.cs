using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class MotherboardPC
    {
        private String product;
        private String manufacturer;
        private String serialNumber;

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public String Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public String Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
