using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopper.BLL
{
    public class FavoriteMachine
    {
        public string DisplayName { get; set; }
        public string MachineAddress { get; set; }
        public string GroupName { get; set; }
        public string MachineName { get; set; }
        public string Platform { get; set; }
        public string KeyName { get; set; }
        public int SshPort { get; set; }
        public string SshUser { get; set; }
    }
}
