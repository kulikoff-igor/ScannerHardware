using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;
using ScannerHardware.WorkingWithData;
using ScannerHardware.DataComputer;

namespace ScannerHardware
{
    public partial class ScannerHardware : Form
    {
        public ScannerHardware()
        {
            InitializeComponent();
        }
        private FormConfigDB config;
        private WorkingWithService readService;
        private WorkingWithStartup readStatup;
        private WorkingWithVideoController videoController;
        private WorkingWithPhysicalMemory physicalMemory;
        private WorkingWithHardDisk hardDisk;
        private WorkingWithNetworkAdapter networkAdapter;
        private WorkingWithMotherboard readMotheboard;
        private WorkingWithOperatingSystem readOS;
        private WorkingWithInstallPrinter installPrinter;
        private WorkingWithProcessor readProcessor;
        private WorkingWithDepartament searchDepartament = new WorkingWithDepartament();
        private WorkingWithEmployeers searchEmployeers = new WorkingWithEmployeers();
        private WorkingWithPersonalComputer personalComputer = new WorkingWithPersonalComputer();
        public void viewService()
        {
            listViewService.Items.Clear();
            listViewService.Columns.Clear();
            listViewService.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewService.View = View.Details;
            listViewService.MultiSelect = false;

            this.listViewService.Columns.Add(new ColumnHeader() { Text = "ID" });
            this.listViewService.Columns.Add(new ColumnHeader() { Text = "Имя службы" });
            this.listViewService.Columns.Add(new ColumnHeader() { Text = "Путь запуска" });
            this.listViewService.Columns.Add(new ColumnHeader() { Text = "Cтатус" });

            readService = new WorkingWithService();
            foreach (ServicePC queryObj in readService.readService())
            {

                ListViewItem lvl = new ListViewItem(queryObj.ProcessId.ToString());
                listViewService.Columns[listViewService.Columns.Count - 1].Width = 75;

                lvl.SubItems.Add(queryObj.DisplayName.ToString());
                listViewService.Columns[listViewService.Columns.Count - 2].Width = 380;

                lvl.SubItems.Add(queryObj.PathName.ToString());
                listViewService.Columns[listViewService.Columns.Count - 3].Width = 280;


                lvl.SubItems.Add(queryObj.State.ToString());
                listViewService.Columns[listViewService.Columns.Count - 4].Width = 45;

                listViewService.Items.Add(lvl);
            }

        }
        public void viewStartap()
        {
            listViewStartup.Items.Clear();
            listViewStartup.Columns.Clear();

            listViewStartup.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewStartup.View = View.Details;
            listViewStartup.MultiSelect = false;

            this.listViewStartup.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewStartup.Columns.Add(new ColumnHeader() { Text = "Имя программы" });
            this.listViewStartup.Columns.Add(new ColumnHeader() { Text = "Путь программы" });

            readStatup = new WorkingWithStartup();
            int iterator = 0;
            foreach (StartupPC queryObj in readStatup.readStartup())
            {

                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewStartup.Columns[listViewStartup.Columns.Count - 1].Width = 400;

                lvl.SubItems.Add(queryObj.NameProgram.ToString());
                listViewStartup.Columns[listViewStartup.Columns.Count - 2].Width = 200;

                lvl.SubItems.Add(queryObj.Command.ToString());
                listViewStartup.Columns[listViewStartup.Columns.Count - 3].Width = 25;

                listViewStartup.Items.Add(lvl);
            }
        }
        public void viewVideoController()
        {
            listViewVideoController.Items.Clear();
            listViewVideoController.Columns.Clear();

            listViewVideoController.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewVideoController.View = View.Details;
            listViewVideoController.MultiSelect = false;

            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "Производитель" });
            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "Модель" });
            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "Память" });
            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "Видео процессор" });
            this.listViewVideoController.Columns.Add(new ColumnHeader() { Text = "Версия драйвера" });

            videoController = new WorkingWithVideoController();
            int iterator = 0;
            foreach (VideoControllerPC queryObj in videoController.readVideoController())
            {

                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 1].Width = 150;

                lvl.SubItems.Add(queryObj.AdapterCompatibility.ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 2].Width = 200;

                lvl.SubItems.Add(queryObj.Caption.ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 3].Width = 100;

                lvl.SubItems.Add(queryObj.AdapterRam.ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 4].Width = 200;

                lvl.SubItems.Add(queryObj.VideoProcessor.ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 5].Width = 150;

                lvl.SubItems.Add(queryObj.DriverVersion.ToString());
                listViewVideoController.Columns[listViewVideoController.Columns.Count - 6].Width = 25;

                listViewVideoController.Items.Add(lvl);
            }
        }
        public void viewPhysicalMemory()
        {
            listViewPhysicalMemory.Items.Clear();
            listViewPhysicalMemory.Columns.Clear();

            listViewPhysicalMemory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPhysicalMemory.View = View.Details;
            listViewPhysicalMemory.MultiSelect = false;

            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "Производитель" });
            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "Модель" });
            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "Память" });
            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "Частота" });
            this.listViewPhysicalMemory.Columns.Add(new ColumnHeader() { Text = "Серийный номер" });

            physicalMemory = new WorkingWithPhysicalMemory();
            int iterator = 0;
            foreach (PhysicalMemoryPC queryObj in physicalMemory.readPhysicalMemory())
            {

                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 1].Width = 150;

                lvl.SubItems.Add(queryObj.Manufacturer.ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 2].Width = 100;

                lvl.SubItems.Add(queryObj.PartNumber.ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 3].Width = 100;

                lvl.SubItems.Add(queryObj.Capacity.ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 4].Width = 200;

                lvl.SubItems.Add(queryObj.Speed.ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 5].Width = 150;

                lvl.SubItems.Add(queryObj.SerialNumber.ToString());
                listViewPhysicalMemory.Columns[listViewPhysicalMemory.Columns.Count - 6].Width = 25;

                listViewPhysicalMemory.Items.Add(lvl);
            }
        }
        public void viewHardDisk()
        {
            listViewHardDisk.Items.Clear();
            listViewHardDisk.Columns.Clear();

            listViewHardDisk.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHardDisk.View = View.Details;
            listViewHardDisk.MultiSelect = false;

            this.listViewHardDisk.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewHardDisk.Columns.Add(new ColumnHeader() { Text = "Модель" });
            this.listViewHardDisk.Columns.Add(new ColumnHeader() { Text = "Разделов" });
            this.listViewHardDisk.Columns.Add(new ColumnHeader() { Text = "Размер" });
            this.listViewHardDisk.Columns.Add(new ColumnHeader() { Text = "Серийный номер" }); ;

            hardDisk = new WorkingWithHardDisk();
            int iterator = 0;
            foreach (HardDiskPC queryObj in hardDisk.readHardDisk())
            {

                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewHardDisk.Columns[listViewHardDisk.Columns.Count - 1].Width = 170;

                lvl.SubItems.Add(queryObj.Model.ToString());
                listViewHardDisk.Columns[listViewHardDisk.Columns.Count - 2].Width = 150;

                lvl.SubItems.Add(queryObj.Partitions.ToString());
                listViewHardDisk.Columns[listViewHardDisk.Columns.Count - 3].Width = 100;

                lvl.SubItems.Add(queryObj.Size.ToString());
                listViewHardDisk.Columns[listViewHardDisk.Columns.Count - 4].Width = 200;

                lvl.SubItems.Add(queryObj.SerialNumber.ToString());
                listViewHardDisk.Columns[listViewHardDisk.Columns.Count - 5].Width = 20;

                listViewHardDisk.Items.Add(lvl);
            }
        }
        public void viewNetworkAdapter()
        {
            listViewNetworkAdapter.Items.Clear();
            listViewNetworkAdapter.Columns.Clear();

            listViewNetworkAdapter.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewNetworkAdapter.View = View.Details;
            listViewNetworkAdapter.MultiSelect = false;

            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "Адаптер" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "MAC адресс" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "Сервисное имя" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "IP адресс" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "Шлюз" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "DNS Server" });
            //this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "DNS Domain" });
            this.listViewNetworkAdapter.Columns.Add(new ColumnHeader() { Text = "DNS HostName" });

            networkAdapter = new WorkingWithNetworkAdapter();
            int iterator = 0;
            foreach (NetworkAdapterPC queryObj in networkAdapter.readNetworkAdapter())
            {
                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 1].Width = 110;

                lvl.SubItems.Add(queryObj.Description.ToString());
                listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 2].Width = 110;

                lvl.SubItems.Add(queryObj.MacAddress.ToString());
                listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 3].Width = 110;

                lvl.SubItems.Add(queryObj.ServiceName.ToString());
                listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 4].Width = 110;
                if (!Equals(queryObj.NetworkSettingsAdapters, default(NetworkSettingsAdapters)))
                {
                    lvl.SubItems.Add(queryObj.NetworkSettingsAdapters.IpAddress.ToString());
                    listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 5].Width = 100;

                    lvl.SubItems.Add(queryObj.NetworkSettingsAdapters.IpDefaultGateway.ToString());
                    listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 6].Width = 130;

                    lvl.SubItems.Add(queryObj.NetworkSettingsAdapters.DhcpServer.ToString());
                    listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 7].Width = 200;

                    //lvl.SubItems.Add(queryObj.NetworkSettingsAdapters.DnsDomain.ToString());
                    //listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 6].Width = 25;

                    lvl.SubItems.Add(queryObj.NetworkSettingsAdapters.DnsHostName.ToString());
                    listViewNetworkAdapter.Columns[listViewNetworkAdapter.Columns.Count - 8].Width = 25;

                    listViewNetworkAdapter.Items.Add(lvl);
                }
                else
                {
                    listViewNetworkAdapter.Items.Add(lvl);
                }
            }
        }
        public void viewOS()
        {
            readOS = new WorkingWithOperatingSystem();
            OperatingSystemPC os = readOS.readOperatingSystem();

            labelCaptionOS.Text = os.Caption;
            labelVersionOS.Text = os.Version;
            labelOSArchitecture.Text = os.Architecture;
            labelSerialNumberOS.Text = os.SerialNumber;
            labelBuildNumberOS.Text = os.BuildNumber;
        }
        public void viewInstallPrinter()
        {
            listViewPrinters.Items.Clear();
            listViewPrinters.Columns.Clear();

            listViewPrinters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPrinters.View = View.Details;
            listViewPrinters.MultiSelect = false;

            this.listViewPrinters.Columns.Add(new ColumnHeader() { Text = "№" });
            this.listViewPrinters.Columns.Add(new ColumnHeader() { Text = "Модель Принтера" });
            this.listViewPrinters.Columns.Add(new ColumnHeader() { Text = "Порт Принтера" });

            installPrinter = new WorkingWithInstallPrinter();
            int iterator = 0;
            foreach (InstallPrinterPC queryObj in installPrinter.readInstallPrinter())
            {
                ListViewItem lvl = new ListViewItem((iterator++).ToString());
                listViewPrinters.Columns[listViewPrinters.Columns.Count - 1].Width = 200;

                lvl.SubItems.Add(queryObj.DeviceID.ToString());
                listViewPrinters.Columns[listViewPrinters.Columns.Count - 2].Width = 200;

                lvl.SubItems.Add(queryObj.PortName.ToString());
                listViewPrinters.Columns[listViewPrinters.Columns.Count - 3].Width = 25;

                listViewPrinters.Items.Add(lvl);
            }
        }
        public void viewMotherboard()
        {
            readMotheboard = new WorkingWithMotherboard();
            MotherboardPC motherboard = readMotheboard.readMotherboard();

            labelManufacturerBoard.Text = motherboard.Manufacturer;
            labelSerialNumberBoard.Text = motherboard.SerialNumber;
            labelProductBoard.Text = motherboard.Product;
        }
        public void viewProcessor()
        {
            readProcessor = new WorkingWithProcessor();
            ProcessorPC processor = readProcessor.readProcessor();

            labelModelProcessor.Text = processor.Model;
            labelL3CacheSize.Text = processor.L3CacheSize;
            labelProcessorId.Text = processor.ProcessorId;
            labelNumberOfCores.Text = processor.NumberOfCores;
            labelNumberOfLogicalProcessors.Text = processor.NumberOfLogicalProcessors;
            labelMaxClockSpeed.Text = processor.MaxClockSpeed;
        }
        public void viewListDepartament()
        {
            comboBoxDepartament.Items.Clear();
            List<String> listDepartament = searchDepartament.searchListDepartaments();
            foreach (String nameDepartament in listDepartament)
            {
                comboBoxDepartament.Items.Add(nameDepartament);
            }
        }
        public void viewListEmployeers(String nameDepartament)
        {
            comboBoxEmployeer.Items.Clear();
            List<String> listEmployeers = searchEmployeers.searchListEmployeers(nameDepartament);
            foreach (String nameEmployeers in listEmployeers)
            {
                comboBoxEmployeer.Items.Add(nameEmployeers);

            }

        }
        private void считатьКонфигурациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewService();
                viewStartap();
                viewOS();
                viewVideoController();
                viewHardDisk();
                viewNetworkAdapter();
                viewInstallPrinter();
                viewMotherboard();
                viewProcessor();
                viewPhysicalMemory();
                button1.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка считывания!" + exception.StackTrace);
            }
        }

        private void ScannerHardware_Load(object sender, EventArgs e)
        {
            try
            {
                viewListDepartament();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show("Ошибка базы данных, проверьте настройки!");
            }

        }

        private void comboBoxDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewListEmployeers(comboBoxDepartament.SelectedItem.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeer.Items.Count == 0 || textBoxInventoryPC.Text.Equals(""))
            {
                MessageBox.Show("Должен быть выбран сотрудник и введен Инв. номер!!!");
            }
            else
            {
                try
                {
                    int idPersonalComputer = personalComputer.insertPersonalComputer(comboBoxEmployeer.SelectedItem.ToString(), Int32.Parse(textBoxInventoryPC.Text));
                    readService.insertService(idPersonalComputer);
                    readStatup.insertStartup(idPersonalComputer);
                    videoController.insertVideoController(idPersonalComputer);
                    physicalMemory.insertPhysicalMemory(idPersonalComputer);
                    hardDisk.insertHardDisk(idPersonalComputer);
                    networkAdapter.insertNetworkAdapter(idPersonalComputer);
                    readMotheboard.insertMotherboard(idPersonalComputer);
                    readOS.insertOperatingSystem(idPersonalComputer);
                    installPrinter.insertInstallPrinter(idPersonalComputer);
                    readProcessor.insertProcessor(idPersonalComputer);
                    MessageBox.Show("Операция Выполнена!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка записи: " + exception.StackTrace);

                }
            }
        }

        private void настройкаПараметровБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config = new FormConfigDB();
            config.Show();
        }

        private void обновитьНастройкиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewListDepartament();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show("Ошибка базы данных, проверьте настройки!");
            }
        }

        private void textBoxInventoryPC_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("->>>>");
            int res;
            bool isInt = Int32.TryParse(textBoxInventoryPC.Text, out res);
            if (isInt == false)
            {
                textBoxInventoryPC.Text = textBoxInventoryPC.Text.Substring(0, textBoxInventoryPC.Text.Length - 1);
            }

        }
    }
}
