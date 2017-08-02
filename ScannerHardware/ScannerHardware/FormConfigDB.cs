using ScannerHardware.WorkWithDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerHardware
{
    public partial class FormConfigDB : Form
    {
        private IniFile ini;
        private ConnectionDatabase connect;
        public FormConfigDB()
        {
            InitializeComponent();
            ini = new IniFile("config.ini");
        }

        private void загрузитьКонфигурациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxUrlBd.Text = ini.ReadINI("Config_BD", "url");
            textBoxNameBd.Text = ini.ReadINI("Config_BD", "name");
            textBoxUserBd.Text = ini.ReadINI("Config_BD", "user");
            textBoxPasswordBd.Text = ini.ReadINI("Config_BD", "pass");
        }

        private void сохранитьКонфигурациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveIniFile();
            MessageBox.Show("Конфигурация сохранена!");
        }

        private void saveIniFile()
        {
            ini = new IniFile("config.ini");
            ini.Write("Config_BD", "url", textBoxUrlBd.Text);
            ini.Write("Config_BD", "name", textBoxNameBd.Text);
            ini.Write("Config_BD", "user", textBoxUserBd.Text);
            ini.Write("Config_BD", "pass", textBoxPasswordBd.Text);

        }

        private void buttonTestBD_Click(object sender, EventArgs e)
        {
            try
            {
                saveIniFile();
                connect = new ConnectionDatabase();
                connect.getConnection().Open();
                connect.getConnection().Close();
                MessageBox.Show("База данных успешна подключена!");
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show("Ошибка базы данных, проверьте настройки!");
            }
        }


    }
}
