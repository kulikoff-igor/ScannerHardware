using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class VideoControllerPC
    {
        private String adapterCompatibility;
        private String caption;
        private String adapterRam;
        private String videoProcessor;
        private String driverVersion;

        public String DriverVersion
        {
            get { return driverVersion; }
            set { driverVersion = value; }
        }
        public String VideoProcessor
        {
            get { return videoProcessor; }
            set { videoProcessor = value; }
        }


        public String AdapterRam
        {
            get { return adapterRam; }
            set { adapterRam = value; }
        }

        public String Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public String AdapterCompatibility
        {
            get { return adapterCompatibility; }
            set { adapterCompatibility = value; }
        }
    }
}
