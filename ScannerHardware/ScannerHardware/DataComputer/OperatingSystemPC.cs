using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware
{
    class OperatingSystemPC
    {
        private String caption;

        public String Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        private String version;

        public String Version
        {
            get { return version; }
            set { version = value; }
        }
        private String architecture;

        public String Architecture
        {
            get { return architecture; }
            set { architecture = value; }
        }
        private String serialNumber;

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        private String buildNumber;

        public String BuildNumber
        {
            get { return buildNumber; }
            set { buildNumber = value; }
        }
    }
}
