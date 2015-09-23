using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopper
{
    public class ScreenSize
    {
        public ScreenSize(Size size)
        {
            Size = size;
        }
        public Size Size { get; private set; }

        public string Value
        {
            get { return string.Format("/w:{0} /h:{1}", Size.Width, Size.Height); }
        }
        public string DisplayText
        {
            get { return string.Format("{0} x {1}", Size.Width, Size.Height); }
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
