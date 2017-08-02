using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class InstallPrinterPC
    {
        private String deviceID;
        private String portName;


        public String PortName
        {
            get { return portName; }
            set { portName = value; }
        }


        public String DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }
    }
}
