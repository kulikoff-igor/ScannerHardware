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
    class WorkingWithNetworkAdapter
    {
        private List<NetworkAdapterPC> listNetworkAdapter;
        public List<NetworkAdapterPC> readNetworkAdapter()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_NetworkAdapterConfiguration ");
            listNetworkAdapter = new List<NetworkAdapterPC>();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                try
                {
                    queryObj["MACAddress"].ToString();

                    NetworkAdapterPC item = new NetworkAdapterPC();
                    item.Description = queryObj["Description"].ToString();
                    item.MacAddress = queryObj["MACAddress"].ToString();
                    item.ServiceName = queryObj["ServiceName"].ToString();


                    try
                    {

                        queryObj["DHCPServer"].ToString();
                        NetworkSettingsAdapters networkSettings = new NetworkSettingsAdapters();
                        networkSettings.IpAddress = ((Array)queryObj["IPAddress"]).GetValue(0).ToString();
                        networkSettings.IpDefaultGateway = ((Array)queryObj["DefaultIPGateway"]).GetValue(0).ToString();
                        networkSettings.DhcpServer = queryObj["DHCPServer"].ToString();
                        networkSettings.DnsHostName = queryObj["DNSHostName"].ToString();

                        item.NetworkSettingsAdapters = networkSettings;

                        listNetworkAdapter.Add(item);

                    }
                    catch (Exception e1)
                    {
                        NetworkSettingsAdapters networkSettings = new NetworkSettingsAdapters();
                        networkSettings = null;
                        item.NetworkSettingsAdapters = networkSettings;
                        listNetworkAdapter.Add(item);
                        continue;
                    }
                }
                catch (Exception e2)
                {
                    continue;
                }
            }
            return listNetworkAdapter;
        }
        public void insertNetworkAdapter(int idPersonalComputer)
        {
            ConnectionDatabase connect = new ConnectionDatabase();
            foreach (NetworkAdapterPC networkAdapter in listNetworkAdapter)
            {
                 
                 String queryString = "INSERT INTO network (adapter_network, MAC_address, name_network, IP_address, gateway_network, DHCPServer, DNS_hostname, id_PC)";

                 if (!Equals(networkAdapter.NetworkSettingsAdapters, default(NetworkSettingsAdapters)))
                {
                    queryString += " VALUES ('" + networkAdapter.Description + "','" + networkAdapter.MacAddress + "','" + networkAdapter.ServiceName + "','" + networkAdapter.NetworkSettingsAdapters.IpAddress + "','" + networkAdapter.NetworkSettingsAdapters.IpDefaultGateway + "','" + networkAdapter.NetworkSettingsAdapters.DhcpServer + "', '" + networkAdapter.NetworkSettingsAdapters.DnsHostName + "', " + idPersonalComputer + ")";   
                }
                else
                {
                    queryString += " VALUES ('" + networkAdapter.Description + "','" + networkAdapter.MacAddress + "','" + networkAdapter.ServiceName + "','-','-','-', '-', " + idPersonalComputer + ")";   
                }
                
               connect.runningQuery(queryString);
               connect.getConnection().Close();
            }
        }
    }
}
