using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerHardware
{
    class ServicePC
    {
        private String processId;

        public String ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }
        private String displayName;

        public String DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private String pathName;

        public String PathName
        {
            get { return pathName; }
            set { pathName = value; }
        }
        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }
        
    }
}
