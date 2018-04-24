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
            RdpFile,
            Favorite,
            Manual
        }

        public enum WindowSizeOption
        {
            FullScreen,
            AllMonitors,
            LargestWindow,
            FullScreenWindow
        }
    }
}
