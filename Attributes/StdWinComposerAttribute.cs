using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class StdWinComposerAttribute : Attribute
    {
        private string _windowname;
        private long _windowid = 0;

        public long WindowID
        {
            get { return _windowid; }
            set { _windowid = value; }
        }

        public StdWinComposerAttribute (string WindowName)
        {
            _windowname = WindowName;
        }
    }
}
