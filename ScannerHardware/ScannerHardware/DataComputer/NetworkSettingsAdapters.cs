using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class NetworkSettingsAdapters
    {
        private String IPAddress;
        private String ipDefaultGateway;
        private String DHCPServer;
        private String DNSDomain;
        private String DNSHostName;

        
        public String DnsHostName
        {
            get { return DNSHostName; }
            set { DNSHostName = value; }
        }

        public String DnsDomain
        {
            get { return DNSDomain; }
            set { DNSDomain = value; }
        }

        public String DhcpServer
        {
            get { return DHCPServer; }
            set { DHCPServer = value; }
        }

        public String IpDefaultGateway
        {
            get { return ipDefaultGateway; }
            set { ipDefaultGateway = value; }
        }

        public String IpAddress
        {
            get { return IPAddress; }
            set { IPAddress = value; }
        }
    }
}
