using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopper
{
    public class EnumTypes
    {
        public enum ServerOption
        {
            RdpFile = 1,
            Favorite = 2,
            Manual = 3
        }

        public enum WindowSizeOption
        {
            FullScreen = 1,
            AllMonitors = 2,
            LargestWindow = 3 ,
            FullScreenWindow = 4
        }
    }
}
