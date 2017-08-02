using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class NetworkAdapterPC
    {
        private String description;
        private String macAddress;
        private String serviceName;
        private NetworkSettingsAdapters networkSettingsAdapters;

        public NetworkSettingsAdapters NetworkSettingsAdapters
        {
            get { return networkSettingsAdapters; }
            set { networkSettingsAdapters = value; }
        }

        public String ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }


        public String MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
