using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopper.BLL
{
    public class Command
    {
        public bool UsePutty { get; set; }
        public string Arguments { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }
}
