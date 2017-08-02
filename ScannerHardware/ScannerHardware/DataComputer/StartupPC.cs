using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware.DataComputer
{
    class StartupPC
    {
        private String nameProgram;
        private String command;

        public String Command
        {
            get { return command; }
            set { command = value; }
        }
        public String NameProgram
        {
            get { return nameProgram; }
            set { nameProgram = value; }
        }

    }
}
